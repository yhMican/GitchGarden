using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour {

	public AudioClip[] levelMusicChangeArray;

	private AudioSource audioSource;


	void Awake () {
		DontDestroyOnLoad (gameObject);
		Debug.Log ("Don't destroy on load: " + name);
	}
	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource> (); // necessary because this script is a different component from Audio Source
	}

	void OnLevelWasLoaded (int level) {
		AudioClip thisLevelMusic = levelMusicChangeArray [level];
		Debug.Log ("Playing clip: " + thisLevelMusic);

		if (thisLevelMusic) {
			audioSource.clip = thisLevelMusic;
			audioSource.loop = true;
			audioSource.Play ();
		}
	}
	
}
