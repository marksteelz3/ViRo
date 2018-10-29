using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopulateFish : MonoBehaviour {

    public GameObject fish;
    private GameObject newFish;

	// Use this for initialization
	void Start () {
       for (int i = 0; i < 200; i++)
        {
            float x = Random.Range(-50, 50);
            float y = Random.Range(0, 30);
            float z = Random.Range(-50, 50);

            if (Mathf.Abs(x) < 10){
                if (Mathf.Abs(z) < 10)
                {
                    if (x > 0)
                    {
                        x += 10;
                    }
                    else
                    {
                        x -= 10;
                    }

                    if (z > 0)
                    {
                        z += 10;
                    }
                    else
                    {
                        z -= 10;
                    }
                }
            }

            newFish = GameObject.Instantiate(fish);
            newFish.transform.position = new Vector3(x, y, z);
            Debug.Log("NEW FISH POSITION: " + newFish.transform.position);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
