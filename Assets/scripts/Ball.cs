using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

	private Paddle paddle;

	Vector3 paddleToBallVector;

	public static bool isGameStarted = false;

	// Use this for initialization
	void Start () {
		paddle = GameObject.FindObjectOfType<Paddle> ();
		paddleToBallVector = this.transform.position - paddle.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (!isGameStarted) {
			this.transform.position = paddle.transform.position + paddleToBallVector;

			if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space)) {
				isGameStarted = true;
				this.GetComponent<Rigidbody2D>().velocity = new Vector2 (3f, 14f);
			}

		}
	}

	void OnCollisionEnter2D () {

		if (isGameStarted) {
			accelerate ();
		}
	}

	void accelerate() {
		Vector2 accel = new Vector2 (Random.Range (0.1f, 0.1f), Random.Range (0.1f, 0.1f));
		this.GetComponent<Rigidbody2D> ().velocity += accel;
	}
}
