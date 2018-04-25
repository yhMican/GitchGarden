﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsManager : MonoBehaviour {

	// const is also static in c#
	const string MASTER_VOLUME_KEY = "master_volume";
	const string DIFFICULTY_KEY = "difficulty";
	const string LEVEL_KEY = "level_unlocked_";

	public static void SetMasterVolume (float volume) {
		if (volume > 0f && volume < 1f) {
			PlayerPrefs.SetFloat (MASTER_VOLUME_KEY, volume);
		} else {
			Debug.LogError ("Master volume out of range");
		}
	}

	public static float GetMasterVolume() {
		return PlayerPrefs.GetFloat (MASTER_VOLUME_KEY);
	}

	public static void UnlockLevel (int level) {
		if (level <= Application.levelCount - 1) {
			PlayerPrefs.SetInt (LEVEL_KEY + level.ToString (), 1); // Use 1 for true
		} else {
			Debug.LogError ("Trying to unlock level not in build order");
		}
	}

	public static bool IsLevelUnlocked (int level) {
		if (level > Application.levelCount - 1) {
			Debug.LogError ("This level is not in build order");
		} else if (PlayerPrefs.GetInt (LEVEL_KEY + level.ToString ()) == 1) {
			return true;
		}
		return false;
	}
}
