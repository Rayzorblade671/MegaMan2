using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
 * Name - Kaitlin Soter
 * 1/17/2018
 * Credit: Project & Portfolio 4 - Mega Man 2 group project
 * Purpose: Contains movement for SelectBoss prefab, and sends player to appropriate level
 */

public class LevelSelection : MonoBehaviour
{

    [SerializeField] Transform selectBoss; // this holds the SelectBoss prefab that shows the player what's highlighted
    public GameObject[] bossPositions; // array that holds all the grid space positions
    int bossIndex = 0;

    //booleans for all the bosses
    bool BubbleMan = false;
    bool AirMan = false;
    bool QuickMan = false;
    bool HeatMan = false;
    bool DrWily = false;
    bool WoodMan = false;
    bool MetalMan = false;
    bool FlashMan = false;
    bool CrashMan = false;

    // Use this for initialization
    void Start()
    {

        Cursor.visible = false; // Setting cursor to invisible

        selectBoss = gameObject.GetComponent<Transform>(); //Setting the transform of the prefab
    }

    // Update is called once per frame
    void Update()
    {

        BoxSelection(); //Calling these functions to check them every frame
        BoxMarked();

        if (MetalMan == true) //If the player hits the Metal Man option, load Metal Man's stage
        {
            SceneManager.LoadScene("TestScene");
        }
    }

    private void BoxSelection()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            if (bossIndex != 2 || bossIndex != 5 || bossIndex != 8)
            {
                bossIndex += 1;

                if (bossIndex > 8)
                {
                    bossIndex = 8;
                }
                selectBoss.position = bossPositions[bossIndex].GetComponent<Transform>().position;
            }
        }

        else if (Input.GetKeyDown(KeyCode.S))
        {
            if (bossIndex < 6)
            {
                bossIndex += 3;

                selectBoss.position = bossPositions[bossIndex].GetComponent<Transform>().position;
            }
        }

        else if (Input.GetKeyDown(KeyCode.W))
        {
            if (bossIndex > 3)
            {
                bossIndex -= 3;

                selectBoss.position = bossPositions[bossIndex].GetComponent<Transform>().position;
            }
        }

        else if (Input.GetKeyDown(KeyCode.A))
        {
            if (bossIndex != 0 || bossIndex != 4 || bossIndex != 7)
            {
                bossIndex -= 1;

                if (bossIndex < 0)
                {
                    bossIndex = 0;
                }

                selectBoss.position = bossPositions[bossIndex].GetComponent<Transform>().position;
            }
        }
    }

    private void BoxMarked()
    {
        if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            if (bossIndex == 0)
            {
                BubbleMan = true;
                Debug.Log(BubbleMan);
            }

            else if (bossIndex == 1)
            {
                AirMan = true;
                Debug.Log(AirMan);
            }


            else if (bossIndex == 2)
            {
                QuickMan = true;
                Debug.Log(QuickMan);
            }


            else if (bossIndex == 3)
            {
                HeatMan = true;
                Debug.Log(HeatMan);
            }


            else if (bossIndex == 4)
            {
                DrWily = true;
                Debug.Log(DrWily);
            }


            else if (bossIndex == 5)
            {
                WoodMan = true;
                Debug.Log(WoodMan);
            }


            else if (bossIndex == 6)
            {
                MetalMan = true;
                Debug.Log(MetalMan);
            }


            else if (bossIndex == 7)
            {
                FlashMan = true;
                Debug.Log(FlashMan);
            }


            else if (bossIndex == 8)
            {
                CrashMan = true;
                Debug.Log(CrashMan);
            }
        }
    }
}
