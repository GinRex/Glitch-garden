using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Defender : MonoBehaviour {
	StarDisplay sd;
	public int starCost;
	void Start() {
		sd = GameObject.FindObjectOfType<StarDisplay> ();
	}


	public void addStar(int amount) {
		sd.AddStars (amount);
	}
}
