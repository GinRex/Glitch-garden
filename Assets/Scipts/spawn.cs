using UnityEngine;
using System.Collections;

public class spawn : MonoBehaviour {
	public GameObject[] attackerPrefArray;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		foreach (GameObject thisAttacker in attackerPrefArray) {
			if (isTimeToSpawn (thisAttacker)) {
				SpawnAtk (thisAttacker);
			}
		}
	}

	bool isTimeToSpawn (GameObject atk) {
		float time = 1/atk.GetComponent<Attacker> ().SeenEverySeconds*Time.deltaTime/5;
		if (Random.value < time) {
			return true;
		}
		return false;
	}

	void SpawnAtk(GameObject gameObj) {
		GameObject mAtk = Instantiate (gameObj, transform.position, Quaternion.identity) as GameObject;
		mAtk.transform.parent = transform;
	}
}
