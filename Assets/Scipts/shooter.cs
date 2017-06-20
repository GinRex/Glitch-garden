using UnityEngine;
using System.Collections;

public class shooter : MonoBehaviour {
	public GameObject projectite;
	GameObject parent;
	private spawn myLane;
	// Use this for initialization

	void Start () {
		parent = GameObject.Find ("Spawner");
		if (!parent) {
			parent =  new GameObject ("Spawner");
		}
		SetMyLaneSpawner ();
	}

	void Update() {
		if (isAttackersInlane ()) {
			GetComponent<Animator> ().SetBool ("isAttacking", true);
		} else {
			GetComponent<Animator> ().SetBool ("isAttacking", false);
		}
	}

	void SetMyLaneSpawner() {
		spawn[] spawnerArray = GameObject.FindObjectsOfType<spawn> ();
		foreach (spawn child in spawnerArray) {
			if (child.transform.position.y == transform.position.y) {
				myLane = child;
			}
		}
	}

	bool isAttackersInlane() {
		if (myLane.transform.childCount > 0) {
			foreach (Transform child in myLane.transform) {
				if (child.position.x > transform.position.x) {
					return true;
				}
			}
			return false;
		} else {
			return false;
		}
	}

	private void Fire() {
		GameObject bullet = Instantiate (projectite, transform.position, Quaternion.identity) as GameObject;
		bullet.transform.parent = parent.transform;
	}
}
