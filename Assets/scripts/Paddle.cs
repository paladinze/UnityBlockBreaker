using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

	public bool isAutoPlay = false;
	private Ball ball;

	// Use this for initialization
	void Start () {
		ball = GameObject.FindObjectOfType<Ball> ();
	}

	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown(KeyCode.Tab)) {
			toggleAutoPlay ();
		}

		if (isAutoPlay) {
			AutoPlay ();
		} else {
			ManualPlay ();
		}
	}
		
	void toggleAutoPlay() {
		isAutoPlay = !isAutoPlay;
	}

	void AutoPlay() {
		Vector3 paddlePos = new Vector3 (ball.transform.position.x, this.transform.position.y, 0f);
		paddlePos.x = Mathf.Clamp(paddlePos.x, 0.5f , 15.5f );
		this.transform.position = paddlePos;
	}

	void ManualPlay() {
		Vector3 paddlePos = new Vector3 (8f, this.transform.position.y, 0f);
		float mousePosInWorldUnits = (Input.mousePosition.x / Screen.width) * 16;
		paddlePos.x = Mathf.Clamp(mousePosInWorldUnits - 0.5f, 0.5f , 15.5f );

		this.transform.position = paddlePos;
	}
}
