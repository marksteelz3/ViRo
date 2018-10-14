using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToClassroom : MonoBehaviour {

	public AudioSource aud;
	public float delay;
	
	// Update is called once per frame
	void Update () {
		if (!aud.isPlaying && Time.time > delay){
            SceneManager.LoadSceneAsync("Classroom");
		}
	}
}
