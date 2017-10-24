using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour {

	public int actualHits;
	public int maxHits;
	public GameObject smokePrefab;

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
			CreateSmoke ();
		}


	}

	void CreateSmoke () {
		GameObject smoke = Instantiate (smokePrefab, gameObject.transform.position, Quaternion.identity);
		ParticleSystem.MainModule main = smoke.GetComponent<ParticleSystem> ().main;

		// change the color of the particle to match block color
		main.startColor = gameObject.GetComponent<SpriteRenderer> ().color;

		// set smoke to appear above blocks
		smoke.transform.position = new Vector3 (smoke.transform.position.x, smoke.transform.position.y, -3f);

		// set smoke density according to maxhits
		var emission = smoke.GetComponent<ParticleSystem> ().emission;
		emission.rateOverTime = 2 * maxHits;
	}
}
