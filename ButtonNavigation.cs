using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonNavigation : MonoBehaviour {

    //make sure to keep UnityEngine.SceneManagement in top

    //Arrow Function Variables
    int index = 0;
    int MenuChoices = 2;
    float yOffset = 1.45f;

    //Making Arrow blink continuously
    private void Start()
    {
        InvokeRepeating("ArrowBlinking", 0f, 0.17f);
    }

    void Update()
    {

//Arrow Function Code

        //If the player presses the S key, move the key down one
        if (Input.GetKeyDown(KeyCode.S))
        {
            if (index <= 0)
            {
                index++;
                Vector2 position = transform.position;
                position.y -= yOffset;
                transform.position = position;
            }
        }

        //If the player presses the W, move the key up one
        if (Input.GetKeyDown(KeyCode.W))
        {
            if (index > 0)
            {
                index--;
                Vector2 position = transform.position;
                position.y += yOffset;
                transform.position = position;
            }
        }

//Scene Loading Code

        //If selecting normal, load the boss selection scene for Normal mode
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (index == 0)
            {
                SceneManager.LoadScene("TestScene");
            }
        }
        //If selecting Difficult, load the boss selection scene for Difficult mode
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (index == 1)
            {
                SceneManager.LoadScene("TestScene");
            }
        }
    }

//Blinking Code

    void ArrowBlinking()
    {
        if (this.GetComponent<MeshRenderer>().enabled == true)
        {
            this.GetComponent<MeshRenderer>().enabled = false;
        }
        else if (this.GetComponent<MeshRenderer>().enabled == false)
        {
            this.GetComponent<MeshRenderer>().enabled = true;
        }
    }
}