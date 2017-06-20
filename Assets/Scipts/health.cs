using UnityEngine;
using System.Collections;

public class health : MonoBehaviour {
	public float hp = 10f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void dealDamage (float health) {
		if (hp > 0) {
			hp -= health;
		} else {
			Destroy (gameObject);
		}
	}
}
