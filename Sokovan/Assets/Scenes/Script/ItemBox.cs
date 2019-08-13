using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox : MonoBehaviour {


    public bool isOverlaped = false;


    private Renderer myRenderer;

    public Color touchColor;
    private Color originalColor;
	// Use this for initialization
	void Start () {
        myRenderer = GetComponent<Renderer>();
        originalColor = myRenderer.material.color;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    // Enter: the monent of collison
    // Unity launch this function automatically, Broadcast OnTrigger Message
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "EndPoint") {
            isOverlaped = true;
            myRenderer.material.color = touchColor;
        }
       
    }
    
    // when collion ended
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "EndPoint")
        {
            isOverlaped = false;
            myRenderer.material.color = originalColor;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Endpoint")
        {
            isOverlaped = true;
            myRenderer.material.color = touchColor;
        }
    }

}
