using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//camel naming: class, function -> Upper case
public class Player : MonoBehaviour {

    public float speed = 10f;
    public Rigidbody playerRigidbody;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {

        // user input
        /*
        if (Input.GetKey(KeyCode.W))
        {
            playerRigidbody.AddForce(0, 0, speed);
        }

        if (Input.GetKey(KeyCode.A))
        {
            playerRigidbody.AddForce(-speed, 0, 0);
        }

        if (Input.GetKey(KeyCode.S))
        {
            playerRigidbody.AddForce(0, 0, -speed);
        }

        if (Input.GetKey(KeyCode.D))
        {
            playerRigidbody.AddForce(speed, 0, 0);
        }
        */

        /* <- or A : return -1   
         -> or D : return 1  
         press noting : return 0 */    
        float inputX = Input.GetAxis("Horizontal");     //"Horizontal" -> horizontal key mapped (<-/->, )
    }
}
