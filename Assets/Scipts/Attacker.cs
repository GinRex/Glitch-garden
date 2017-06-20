using UnityEngine;
using System.Collections;

public class Attacker : MonoBehaviour {
	GameObject currentTarget;
	public float SeenEverySeconds;
	[Range(-1f, 1.5f)] public float currentSpeed;

	// Use this for initialization
	void Start () {
		Rigidbody2D mRigidBody = gameObject.AddComponent<Rigidbody2D> ();
		mRigidBody.isKinematic = true;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.left * currentSpeed * Time.deltaTime);
		if (!currentTarget) {
			GetComponent<Animator> ().SetBool ("IsAtackingTrigger", false);
		}
	}

	public void SetSpeed (float speed) {
		currentSpeed = speed;
	}

	public void StrikeCurrentTarget(float damage) {
		Debug.Log (gameObject.name + damage);
		if (currentTarget) {
			currentTarget.GetComponent<health> ().dealDamage (damage);
		}
	}

	public void Attack(GameObject obj) {
		currentTarget = obj;	
	}
}
