using UnityEngine;
using System.Collections;

public class DefenderSpawner : MonoBehaviour {
	public Camera mCamera;
	private StarDisplay sd;
	GameObject parent;
	void Start () {
		parent = GameObject.Find ("Defenders");
		if (!parent) {
			parent = new GameObject ("Defenders");
		}
		sd = GameObject.FindObjectOfType<StarDisplay> ();
	}

	void OnMouseDown () {
		print (CalMouseWorldPoint());
		int cost = Button.selectedButton.GetComponent<Defender> ().starCost;
		if (sd.UseStars(cost) == StarDisplay.Status.SUCCESS) {
			GameObject defenders = Instantiate (Button.selectedButton, CalMouseWorldPoint (), Quaternion.identity) as GameObject;
			defenders.transform.parent = parent.transform;
		}
	}


	Vector3 CalMouseWorldPoint () {
		Vector3 Triplet = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, 10f);
		Vector3 worldPoint = mCamera.ScreenToWorldPoint (Triplet);
		worldPoint.x =  Mathf.Round (worldPoint.x);
		worldPoint.y =  Mathf.Round (worldPoint.y);
		return worldPoint;
	}
}
