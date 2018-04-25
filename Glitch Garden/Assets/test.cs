using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		print (PlayerPrefsManager.GetMasterVolume ());
		PlayerPrefsManager.SetMasterVolume (0.3f);
		print (PlayerPrefsManager.GetMasterVolume ());

		PlayerPrefsManager.UnlockLevel (2);

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
