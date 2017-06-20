using UnityEngine;
using System.Collections;

public class LoseZone : MonoBehaviour {
	public int health = 3;
	void OnTriggerEnter2D (Collider2D col) {
		Destroy (col.gameObject);

		if (health > 0) {
			health--;
		} else {
			UnityEngine.SceneManagement.SceneManager.LoadScene ("Lose Screen");
		}
	}
}
