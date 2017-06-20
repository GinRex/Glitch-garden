using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour {
	public GameObject defPrefab;
	private Button[] btnArray;
	public static GameObject selectedButton;
	// Use this for initialization
	void Start () {
		btnArray = GameObject.FindObjectsOfType<Button> ();
	}

	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown(){

		foreach (Button thisbtn in btnArray) {
			thisbtn.GetComponent<SpriteRenderer> ().color = Color.black;
		}
		GetComponent<SpriteRenderer> ().color = Color.white;

		selectedButton = defPrefab;

	}
}
