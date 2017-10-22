using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour {

	public int actualHits;
	public int maxHits;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D (Collision2D col) {
		actualHits++;

		// destroy the block game object
		if (actualHits >= maxHits) {
			Destroy(gameObject);
		}


	}
}
