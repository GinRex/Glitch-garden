using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	public float autoLoadNextLevel = 0f;

	void Start() {
		Invoke ("LoadNextLevel", autoLoadNextLevel);	
	}

	public void LoadLevel(string name){
		SceneManager.LoadScene (name);
	}

	public void LoadLevelDiff () {
		SceneManager.LoadScene ("Level_0" + PlayerPrefsManager.GetDifficulty().ToString());
	}

	public void QuitRequest(){
		Debug.Log ("Quit requested");
		Application.Quit ();
	}

	public void LoadNextLevel () {
		SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex + 1);
	}
}
