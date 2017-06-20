using UnityEngine;
using System.Collections;


public class lizzard : MonoBehaviour {

	public float damage = 5f;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D (Collider2D col) {
		GameObject obj = col.gameObject;
		if (!obj.GetComponent<Defender> ()) {
			return;
		} else {
			GetComponent<Animator> ().SetBool ("IsAtackingTrigger", true);
			GetComponent<Attacker> ().Attack (obj);
		}
	}
}
