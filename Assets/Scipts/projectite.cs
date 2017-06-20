using UnityEngine;
using System.Collections;

public class projectite : MonoBehaviour {
	public float speed = 1f, damage = 5f;
	GameObject currentTarget;
	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.right * speed * Time.deltaTime);
	}

	void OnTriggerEnter2D (Collider2D col) {
		if (col.GetComponent<Attacker> ()) {
			col.GetComponent<health> ().dealDamage (damage);
			Destroy (gameObject);
		}
	}
}
