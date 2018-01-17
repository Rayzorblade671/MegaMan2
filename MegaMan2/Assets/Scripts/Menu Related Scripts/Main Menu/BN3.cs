using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BN3 : MonoBehaviour {
    //make sure to keep UnityEngine.SceneManagement in top

    // Camera moving functions
    public GameObject MainCam; //Calling the Camera
    public Animator MainCamAnim; //Getting the animation from the camera
    private bool transition = false; //toggling the boolean to start the animation

    //Arrow Function Variables
    int index = 0;
    int MenuChoices = 3;
    private float yOffset = 1.3f;

    //Making Arrow blink continuously
    private void Start()
    {
        InvokeRepeating("ArrowBlinking", 0f, 0.17f);
        MainCamAnim = MainCam.GetComponent<Animator>();
        transition = true;
    }

    void Update()
    {

        TransitionCamera();

        //Arrow Function Code

        //If the player presses the S key, move the key down one
        if (Input.GetKeyDown(KeyCode.S))
        {
            if (index <= MenuChoices - 1)
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

        //If selecting Continue, load the level they died on
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (index == 0)
            {
                SceneManager.LoadScene("TestScene");
            }
        }
        //If selecting Stage Select, load the Boss Selection Scene
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (index == 1)
            {
                SceneManager.LoadScene("BossLevel");
            }
        }
        //If selecting Password, load the Password Scene
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (index == 2)
            {
                SceneManager.LoadScene("PasswordInput");
            }
        }
    }

    void TransitionCamera()
    {
        if(transition == true)
        {
            MainCamAnim.SetBool("transition", true);
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