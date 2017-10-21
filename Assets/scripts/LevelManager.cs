using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	// Use this for initialization
	public void LoadLevel(string name) {
		Debug.Log ("Load Level " + name);
		SceneManager.LoadScene(name);
	}

	public void QuitHandler() {
		Debug.Log ("Quit");
	}
}