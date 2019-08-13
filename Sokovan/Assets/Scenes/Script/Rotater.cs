using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Rotater : MonoBehaviour {

    public float rotateSpeed;
    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        rotateSpeed = 60 * Time.deltaTime;
        transform.Rotate(rotateSpeed, rotateSpeed, rotateSpeed);   //transform(shortcut), TIme.deltaTIme = FPS
    }
}
