using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour {


    public Light ll; 
	// Use this for initialization
	void Start () {
        ll = GetComponent<Light>();
        RenderSettings.ambientLight = Color.black; 
	}
	
	// Update is called once per frame
	void Update () {
        ll.intensity = ll.intensity - 0.1f;
        RenderSettings.ambientLight = Color.black;

    }
}
