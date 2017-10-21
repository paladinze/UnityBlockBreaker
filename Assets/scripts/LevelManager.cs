using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	public void LoadLevel(string name) {
		Debug.Log ("Load Level " + name);
		SceneManager.LoadScene(name);
	}

	public void LoadNextLevel() {
		SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex);
		Debug.Log ("Load next Level " + SceneManager.GetActiveScene().name);
	}

	public void QuitHandler() {
		Debug.Log ("Quit");
	}
}