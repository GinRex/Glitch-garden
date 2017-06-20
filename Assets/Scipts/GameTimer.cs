using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameTimer : MonoBehaviour {
	public Slider timer;
	private GameObject winLabel;
	// Use this for initialization
	void Start () {
		winLabel = GameObject.Find ("you win");
		winLabel.SetActive (false);
		timer = GetComponent<Slider> ();
		timer.value = 0;
		timer.minValue = 0;
		timer.maxValue = 100;
	}
	
	// Update is called once per frame
	void Update () {
		timer.value+= timer.maxValue/7000;
		if (timer.value == timer.maxValue) {
			winLabel.SetActive(true);
			GameObject spn = GameObject.Find ("Spawner");
			Destroy (spn);
			Invoke("win", 4f);		
		}
	}

	void win(){
		UnityEngine.SceneManagement.SceneManager.LoadScene ("Win Screen");
	}
}
