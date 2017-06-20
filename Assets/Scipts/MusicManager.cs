using UnityEngine;
using System.Collections;

public class MusicManager : MonoBehaviour {

	public AudioClip[] musicBox;
	private AudioSource music;

	void Awake() {
		DontDestroyOnLoad (gameObject);	
	}

	void Start(){
		music =  GetComponent<AudioSource> ();
	}

	public void ChangeVolume (float volume) {
		music.volume = volume;
	}

	void OnLevelWasLoaded(int level) {
		if (music) {
			music.Stop ();

			if (musicBox [level]) {
				music.clip = musicBox [level];
				music.loop = true;
				music.Play ();
			}

		}
	}
}
