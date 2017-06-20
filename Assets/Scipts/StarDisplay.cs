using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class StarDisplay : MonoBehaviour {
	private Text starNumber;
	public int Stars = 100; 
	public enum Status {SUCCESS, FAILURE};
	// Use this for initialization
	void Start () {
		starNumber = GetComponent<Text> ();
	}
	
	void Update() {
		starNumber.text = Stars.ToString();
	}

	public void AddStars(int amount) {
		Stars += amount;
	}

	public Status UseStars (int amount) {
		if (Stars >= amount) { 
			Stars -= amount;
			return Status.SUCCESS;
		}
		return Status.FAILURE;
	}
}
