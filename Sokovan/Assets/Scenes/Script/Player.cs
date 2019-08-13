using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//camel naming: class, function -> Upper case
public class Player : MonoBehaviour {

    public float speed = 10f;
    private Rigidbody playerRigidbody;

	// Use this for initialization
	void Start () {
        // GetComponent -> search <?> in game component
        playerRigidbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {

        // user input
        /* <- or A : return -1   
         -> or D : return 1  
         press noting : return 0 */    
        float inputX = Input.GetAxis("Horizontal");     //"Horizontal" -> horizontal key mapped (<-/->, )
        float inputZ = Input.GetAxis("Vertical");     //"Horizontal" -> horizontal key mapped (<-/->, )

        float fallSpeed = playerRigidbody.velocity.y;

        Vector3 velocity = new Vector3(inputX, 0, inputZ);
        velocity *= speed;
        velocity.y = fallSpeed;

        playerRigidbody.velocity = velocity;

    }
}
