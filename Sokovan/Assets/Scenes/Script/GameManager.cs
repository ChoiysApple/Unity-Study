using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {


    public ItemBox[] itemBoxes;
    public GameObject winUI;

    public bool isGameOver;
	// Use this for initialization
	void Start () {
        winUI.SetActive(false);
        isGameOver = false;
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        if (isGameOver)
        {
            winUI.SetActive(true);
            return;
        }

        int count = 0;
        for(int i = 0; i < 3; i++)
        {
            if (itemBoxes[i].isOverlaped)
            {
                count++;
            }
        }

        if (count == 3)
        {
            Debug.Log("Victory");
            isGameOver = true;
        }
	}
}
