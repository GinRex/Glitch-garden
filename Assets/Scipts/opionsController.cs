using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class opionsController : MonoBehaviour {

	public Slider volumeSlider;
	public Slider diffSlider;
	public LevelManager levelManager;
	private MusicManager musicManager;

	void Start (){
		musicManager = FindObjectOfType<MusicManager> ();
		volumeSlider.value = PlayerPrefsManager.GetMasterVolume ();
		diffSlider.value = PlayerPrefsManager.GetDifficulty ();
	}

	void Update () {
		musicManager.ChangeVolume (volumeSlider.value);
	}

	public void SaveNExit() {
		PlayerPrefsManager.SetDifficulty ((int)diffSlider.value);
		PlayerPrefsManager.SetMasterVolume (volumeSlider.value);
		levelManager.LoadLevel ("Start Menu");
	} 
}
