using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using VRTK;

public class GrabSceneLoader : MonoBehaviour {
	
	public string sceneToLoad;
	public VRTK_InteractableObject grabber;
	private bool hasBeenGrabbed;


	void Start(){
		hasBeenGrabbed = false;
	}

	// Update is called once per frame
	void Update () {
		if (grabber.IsGrabbed() && !hasBeenGrabbed){
			LoadScene();
			hasBeenGrabbed = true;
		}
	}

	void LoadScene(){
		SceneManager.LoadSceneAsync(sceneToLoad);
	}
}
