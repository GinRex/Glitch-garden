using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FadedImage : MonoBehaviour {

	public float fadeInTime;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.timeSinceLevelLoad < fadeInTime) {
			this.GetComponent<Image> ().CrossFadeAlpha (0f, fadeInTime, true);
		} else {
			gameObject.SetActive (false);
		}
	}
}
