using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishMovementScript : MonoBehaviour {

    public Rigidbody rb;

    public Camera cam;

    private float initXDiff, initZDiff;

    public int time = 0;

    private int t1, t2, t3, t4;
    private Vector3 initPos;

    private bool first = true;

    void Awake()
    {

        // Fix clockwise or counter clockwise
        /*if (Vector3.Distance(Vector3.zero, pathCenter) > Vector3.Distance(Vector3.zero, transform.position)){
            transform.Rotate(Vector3.up, 180);
        }*/


        // Save initial x and z coordinates

    }

    void Start()
    {


    }

    void Update()
    {
        if (first){
            initXDiff = transform.position.x;
            initZDiff = transform.position.z;
            initPos = new Vector3(initXDiff, 0, initZDiff);
            Debug.Log("INITIAL FISH POSITION: " + initPos);

            Vector3 direction = new Vector3(initXDiff, 0, initZDiff);
            Vector3 tangent = new Vector3(-initZDiff, 0, initXDiff);

            // Position each fish tangent to its path circle
            float angleChange = Vector3.Angle(Vector3.forward, tangent);
            if (initZDiff > 0){
                this.gameObject.transform.Rotate(Vector3.up, -angleChange);
            } else {
                this.gameObject.transform.Rotate(Vector3.up, angleChange);
            }


            //t1 = (int)Random.Range(1800, 2400); // die between 30-40 seconds
            t1 = (int)Random.Range(1800, 2400);
            t2 = t1 + 150; // roll over, beethoven
            t3 = t1 + 240; // add force for 4 seconds after death
            t4 = t3 + 360;
            first = false;

        }
        rb = GetComponent<Rigidbody>();
        if (time < t1){
            float radius = Vector3.Distance(initPos, Vector3.zero);
            float circumference = 2 * radius * Mathf.PI;

            float rotationCoeff = Random.Range(0.25f, 2.0f);

            float rotateBy = -(.5f) * (1 / 360) * circumference;
            transform.Rotate(Vector3.up, (rotateBy * rotationCoeff));
            float rotateAround = -0.5f;
            transform.RotateAround(Vector3.zero, Vector3.up, (rotateAround * rotationCoeff));

        } else if (time < t3){
            if (time < t2){
                transform.Rotate(Vector3.forward, 1.5f);
            }

            rb.AddForce(new Vector3(0, 2, 0));
        } else if (time == t4){
            Destroy(gameObject);
        }

        time++;
    }
}
