using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerPrefsManager : MonoBehaviour {

	const  string MASTER_VOLUME_KEY = "master_volume";
	const string DIFFICULTY_KEY = "difficulty";
	const string LEVEL_KEY = "level_unlocked_";

	public static void SetMasterVolume (float volume) {
		if (volume >= 0f && volume <= 1f) {
			PlayerPrefs.SetFloat (MASTER_VOLUME_KEY, volume);
		} else {
			Debug.LogError ("Master voulume out OffMeshLink range");
		}
	}

	public static float GetMasterVolume () {
		return PlayerPrefs.GetFloat (MASTER_VOLUME_KEY);
	}

	public static void SetLevelUnlock (int level) {
		if (level < SceneManager.sceneCountInBuildSettings) {
			PlayerPrefs.SetInt (LEVEL_KEY + level.ToString(), 1);
		}
	}

	public static bool GetLevelUnlocked (int level) {
		int levelVal = PlayerPrefs.GetInt (LEVEL_KEY + level.ToString());
		if (level == 1) {
			return true;
		}
		return false;
	}

	public static void SetDifficulty (int diff) {
		if (diff >= 1 && diff <= 3) {
			PlayerPrefs.SetInt (DIFFICULTY_KEY, diff);
		}
	}

	public static int GetDifficulty () {
		return PlayerPrefs.GetInt (DIFFICULTY_KEY);
	}
}
