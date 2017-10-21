using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {

		Vector3 paddlePos = new Vector3 (8f, this.transform.position.y, 0f);
		float mousePosInWorldUnits = (Input.mousePosition.x / Screen.width) * 16;
		paddlePos.x = Mathf.Clamp(mousePosInWorldUnits - 0.5f, 0.5f , 15.5f );

		this.transform.position = paddlePos;
	}
}
