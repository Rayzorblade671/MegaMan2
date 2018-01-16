﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PasswordScript : MonoBehaviour {

    [SerializeField] Transform selectBoss; // this holds the SelectBoss prefab that shows the player what's highlighted
    public GameObject[] RedPins; // array that holds all the red pin locations
    public GameObject[] tilePositions; // array that holds all the grid space positions
    bool boxUsed = false; // a bool to check if the Box is currently being used so that I can't press Enter twice
    private int pinCount = 0; // the int that counts how many pins I have on the board
    int boxIndex = 0;
    bool CorrectPW;

    // Use this for initialization
    void Start() {

        selectBoss = gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update() {
        BoxSelection();
        BoxMarked();

        if (CorrectPW == true)
        {
            SceneManager.LoadScene("TestScene");
        }

        else if(pinCount >= 9)
        {
            if (tilePositions[1].GetComponent<BoxCheck>().boxChecked == true && tilePositions[5].GetComponent<BoxCheck>().boxChecked == true)
            {
                print("2requirements met");
                if (tilePositions[11].GetComponent<BoxCheck>().boxChecked == true && tilePositions[14].GetComponent<BoxCheck>().boxChecked == true)
                {
                    print("4 requirements met");
                    if (tilePositions[15].GetComponent<BoxCheck>().boxChecked == true && tilePositions[16].GetComponent<BoxCheck>().boxChecked == true)
                    {
                        print("6 requirements met");
                        if (tilePositions[18].GetComponent<BoxCheck>().boxChecked == true && tilePositions[20].GetComponent<BoxCheck>().boxChecked == true)
                        {
                            print("8 requirements met");
                              if(tilePositions[23].GetComponent<BoxCheck>().boxChecked == true)
                            {
                                print("password correct");
                                CorrectPW = true;
                                Debug.Log(CorrectPW);
                            }
                        }
                    }
                }
            } 
        }

        else if (pinCount >= 9)
        {
            CorrectPW = false;
            if (CorrectPW == false)
            {
                SceneManager.LoadScene("StartPassword");
            }
        }
    }

    private void BoxSelection()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            if (boxIndex != 4 || boxIndex != 9 || boxIndex != 14 || boxIndex != 19 || boxIndex != 24)
            {
                boxIndex += 1;

                if (boxIndex > 24)
                {
                    boxIndex = 24;
                }
                selectBoss.position = tilePositions[boxIndex].GetComponent<Transform>().position;
            }
        }

        else if (Input.GetKeyDown(KeyCode.S))
        {
            if (boxIndex < 20)
            {
                boxIndex += 5;

                selectBoss.position = tilePositions[boxIndex].GetComponent<Transform>().position;
            }
        }

        else if (Input.GetKeyDown(KeyCode.W))
        {
            if (boxIndex > 4)
            {
                boxIndex -= 5;

                selectBoss.position = tilePositions[boxIndex].GetComponent<Transform>().position;
            }
        }

        else if (Input.GetKeyDown(KeyCode.A))
        {
            if (boxIndex != 0 || boxIndex != 5 || boxIndex != 10 || boxIndex != 15 || boxIndex != 20)
            {
                boxIndex -= 1;

                if (boxIndex < 0)
                {
                    boxIndex = 0;
                }

                selectBoss.position = tilePositions[boxIndex].GetComponent<Transform>().position;
            }
        }
    }

    private void BoxMarked()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (boxIndex == 0)
            {
                if (tilePositions[boxIndex].GetComponent<BoxCheck>().boxChecked == false)
                {
                    tilePositions[boxIndex].GetComponent<BoxCheck>().boxChecked = true; // setting the box on that position to being used
                    Debug.Log(tilePositions[boxIndex].GetComponent<BoxCheck>().boxChecked); // adding a debug to make sure it's working
                    RedPins[0].SetActive(true); // make the red pin visible
                    pinCount++; // add the now visible pin to the int
                    Debug.Log(pinCount); // debug to check how many pins I currently am storing in the pin count int
                }
            }

            else if (boxIndex == 1)
            {
                if (tilePositions[boxIndex].GetComponent<BoxCheck>().boxChecked == false)
                {
                    tilePositions[boxIndex].GetComponent<BoxCheck>().boxChecked = true; // setting the box on that position to being used
                    Debug.Log(tilePositions[boxIndex].GetComponent<BoxCheck>().boxChecked); // adding a debug to make sure it's working
                    RedPins[1].SetActive(true); // make the red pin visible
                    pinCount++; // add the now visible pin to the int
                    Debug.Log(pinCount); // debug to check how many pins I currently am storing in the pin count int
                }
            }


                else if (boxIndex == 2)
                {
                    if (tilePositions[boxIndex].GetComponent<BoxCheck>().boxChecked == false)
                    {
                        tilePositions[boxIndex].GetComponent<BoxCheck>().boxChecked = true; // setting the box on that position to being used
                        Debug.Log(tilePositions[boxIndex].GetComponent<BoxCheck>().boxChecked); // adding a debug to make sure it's working
                        RedPins[2].SetActive(true); // make the red pin visible
                        pinCount++; // add the now visible pin to the int
                        Debug.Log(pinCount); // debug to check how many pins I currently am storing in the pin count int
                    }
                }


                else if (boxIndex == 3)
                {
                    if (tilePositions[boxIndex].GetComponent<BoxCheck>().boxChecked == false)
                    {
                        tilePositions[boxIndex].GetComponent<BoxCheck>().boxChecked = true; // setting the box on that position to being used
                        Debug.Log(tilePositions[boxIndex].GetComponent<BoxCheck>().boxChecked); // adding a debug to make sure it's working
                        RedPins[3].SetActive(true); // make the red pin visible
                        pinCount++; // add the now visible pin to the int
                        Debug.Log(pinCount); // debug to check how many pins I currently am storing in the pin count int
                    }
                }


                else if (boxIndex == 4)
                {
                    if (tilePositions[boxIndex].GetComponent<BoxCheck>().boxChecked == false)
                    {
                        tilePositions[boxIndex].GetComponent<BoxCheck>().boxChecked = true; // setting the box on that position to being used
                        Debug.Log(tilePositions[boxIndex].GetComponent<BoxCheck>().boxChecked); // adding a debug to make sure it's working
                        RedPins[4].SetActive(true); // make the red pin visible
                        pinCount++; // add the now visible pin to the int
                        Debug.Log(pinCount); // debug to check how many pins I currently am storing in the pin count int
                    }
                }


                else if (boxIndex == 5)
                {
                    if (tilePositions[boxIndex].GetComponent<BoxCheck>().boxChecked == false)
                    {
                        tilePositions[boxIndex].GetComponent<BoxCheck>().boxChecked = true; // setting the box on that position to being used
                        Debug.Log(tilePositions[boxIndex].GetComponent<BoxCheck>().boxChecked); // adding a debug to make sure it's working
                        RedPins[5].SetActive(true); // make the red pin visible
                        pinCount++; // add the now visible pin to the int
                        Debug.Log(pinCount); // debug to check how many pins I currently am storing in the pin count int
                    }
                }


                else if (boxIndex == 6)
                {
                    if (tilePositions[boxIndex].GetComponent<BoxCheck>().boxChecked == false)
                    {
                        tilePositions[boxIndex].GetComponent<BoxCheck>().boxChecked = true; // setting the box on that position to being used
                        Debug.Log(tilePositions[boxIndex].GetComponent<BoxCheck>().boxChecked); // adding a debug to make sure it's working
                        RedPins[6].SetActive(true); // make the red pin visible
                        pinCount++; // add the now visible pin to the int
                        Debug.Log(pinCount); // debug to check how many pins I currently am storing in the pin count int
                    }
                }


                else if (boxIndex == 7)
                {
                    if (tilePositions[boxIndex].GetComponent<BoxCheck>().boxChecked == false)
                    {
                        tilePositions[boxIndex].GetComponent<BoxCheck>().boxChecked = true; // setting the box on that position to being used
                        Debug.Log(tilePositions[boxIndex].GetComponent<BoxCheck>().boxChecked); // adding a debug to make sure it's working
                        RedPins[7].SetActive(true); // make the red pin visible
                        pinCount++; // add the now visible pin to the int
                        Debug.Log(pinCount); // debug to check how many pins I currently am storing in the pin count int
                    }
                }


                else if (boxIndex == 8)
                {
                    if (tilePositions[boxIndex].GetComponent<BoxCheck>().boxChecked == false)
                    {
                        tilePositions[boxIndex].GetComponent<BoxCheck>().boxChecked = true; // setting the box on that position to being used
                        Debug.Log(tilePositions[boxIndex].GetComponent<BoxCheck>().boxChecked); // adding a debug to make sure it's working
                        RedPins[8].SetActive(true); // make the red pin visible
                        pinCount++; // add the now visible pin to the int
                        Debug.Log(pinCount); // debug to check how many pins I currently am storing in the pin count int
                    }
                }


                else if (boxIndex == 9)
                {
                    if (tilePositions[boxIndex].GetComponent<BoxCheck>().boxChecked == false)
                    {
                        tilePositions[boxIndex].GetComponent<BoxCheck>().boxChecked = true; // setting the box on that position to being used
                        Debug.Log(tilePositions[boxIndex].GetComponent<BoxCheck>().boxChecked); // adding a debug to make sure it's working
                        RedPins[9].SetActive(true); // make the red pin visible
                        pinCount++; // add the now visible pin to the int
                        Debug.Log(pinCount); // debug to check how many pins I currently am storing in the pin count int
                    }
                }


                else if (boxIndex == 10)
                {
                    if (tilePositions[boxIndex].GetComponent<BoxCheck>().boxChecked == false)
                    {
                        tilePositions[boxIndex].GetComponent<BoxCheck>().boxChecked = true; // setting the box on that position to being used
                        Debug.Log(tilePositions[boxIndex].GetComponent<BoxCheck>().boxChecked); // adding a debug to make sure it's working
                        RedPins[10].SetActive(true); // make the red pin visible
                        pinCount++; // add the now visible pin to the int
                        Debug.Log(pinCount); // debug to check how many pins I currently am storing in the pin count int
                    }
                }


                else if (boxIndex == 11)
                {
                    if (tilePositions[boxIndex].GetComponent<BoxCheck>().boxChecked == false)
                    {
                        tilePositions[boxIndex].GetComponent<BoxCheck>().boxChecked = true; // setting the box on that position to being used
                        Debug.Log(tilePositions[boxIndex].GetComponent<BoxCheck>().boxChecked); // adding a debug to make sure it's working
                        RedPins[11].SetActive(true); // make the red pin visible
                        pinCount++; // add the now visible pin to the int
                        Debug.Log(pinCount); // debug to check how many pins I currently am storing in the pin count int
                    }
                }


                else if (boxIndex == 12)
                {
                    if (tilePositions[boxIndex].GetComponent<BoxCheck>().boxChecked == false)
                    {
                        tilePositions[boxIndex].GetComponent<BoxCheck>().boxChecked = true; // setting the box on that position to being used
                        Debug.Log(tilePositions[boxIndex].GetComponent<BoxCheck>().boxChecked); // adding a debug to make sure it's working
                        RedPins[12].SetActive(true); // make the red pin visible
                        pinCount++; // add the now visible pin to the int
                        Debug.Log(pinCount); // debug to check how many pins I currently am storing in the pin count int
                    }
                }


                else if (boxIndex == 13)
                {
                    if (tilePositions[boxIndex].GetComponent<BoxCheck>().boxChecked == false)
                    {
                        tilePositions[boxIndex].GetComponent<BoxCheck>().boxChecked = true; // setting the box on that position to being used
                        Debug.Log(tilePositions[boxIndex].GetComponent<BoxCheck>().boxChecked); // adding a debug to make sure it's working
                        RedPins[13].SetActive(true); // make the red pin visible
                        pinCount++; // add the now visible pin to the int
                        Debug.Log(pinCount); // debug to check how many pins I currently am storing in the pin count int
                    }
                }


                else if (boxIndex == 14)
                {
                    if (tilePositions[boxIndex].GetComponent<BoxCheck>().boxChecked == false)
                    {
                        tilePositions[boxIndex].GetComponent<BoxCheck>().boxChecked = true; // setting the box on that position to being used
                        Debug.Log(tilePositions[boxIndex].GetComponent<BoxCheck>().boxChecked); // adding a debug to make sure it's working
                        RedPins[14].SetActive(true); // make the red pin visible
                        pinCount++; // add the now visible pin to the int
                        Debug.Log(pinCount); // debug to check how many pins I currently am storing in the pin count int
                    }
                }


                else if (boxIndex == 15)
                {
                    if (tilePositions[boxIndex].GetComponent<BoxCheck>().boxChecked == false)
                    {
                        tilePositions[boxIndex].GetComponent<BoxCheck>().boxChecked = true; // setting the box on that position to being used
                        Debug.Log(tilePositions[boxIndex].GetComponent<BoxCheck>().boxChecked); // adding a debug to make sure it's working
                        RedPins[15].SetActive(true); // make the red pin visible
                        pinCount++; // add the now visible pin to the int
                        Debug.Log(pinCount); // debug to check how many pins I currently am storing in the pin count int
                    }
                }


                else if (boxIndex == 16)
                {
                    if (tilePositions[boxIndex].GetComponent<BoxCheck>().boxChecked == false)
                    {
                        tilePositions[boxIndex].GetComponent<BoxCheck>().boxChecked = true; // setting the box on that position to being used
                        Debug.Log(tilePositions[boxIndex].GetComponent<BoxCheck>().boxChecked); // adding a debug to make sure it's working
                        RedPins[16].SetActive(true); // make the red pin visible
                        pinCount++; // add the now visible pin to the int
                        Debug.Log(pinCount); // debug to check how many pins I currently am storing in the pin count int
                    }
                }
            

                else if (boxIndex == 17)
                {
                    if (tilePositions[boxIndex].GetComponent<BoxCheck>().boxChecked == false)
                    {
                        tilePositions[boxIndex].GetComponent<BoxCheck>().boxChecked = true; // setting the box on that position to being used
                        Debug.Log(tilePositions[boxIndex].GetComponent<BoxCheck>().boxChecked); // adding a debug to make sure it's working
                        RedPins[17].SetActive(true); // make the red pin visible
                        pinCount++; // add the now visible pin to the int
                        Debug.Log(pinCount); // debug to check how many pins I currently am storing in the pin count int
                    }
                }
            

                else if (boxIndex == 18)
                {
                    if (tilePositions[boxIndex].GetComponent<BoxCheck>().boxChecked == false)
                    {
                        tilePositions[boxIndex].GetComponent<BoxCheck>().boxChecked = true; // setting the box on that position to being used
                        Debug.Log(tilePositions[boxIndex].GetComponent<BoxCheck>().boxChecked); // adding a debug to make sure it's working
                        RedPins[18].SetActive(true); // make the red pin visible
                        pinCount++; // add the now visible pin to the int
                        Debug.Log(pinCount); // debug to check how many pins I currently am storing in the pin count int
                    }
                }
            

                else if (boxIndex == 19)
                {
                    if (tilePositions[boxIndex].GetComponent<BoxCheck>().boxChecked == false)
                    {
                        tilePositions[boxIndex].GetComponent<BoxCheck>().boxChecked = true; // setting the box on that position to being used
                        Debug.Log(tilePositions[boxIndex].GetComponent<BoxCheck>().boxChecked); // adding a debug to make sure it's working
                        RedPins[19].SetActive(true); // make the red pin visible
                        pinCount++; // add the now visible pin to the int
                        Debug.Log(pinCount); // debug to check how many pins I currently am storing in the pin count int
                    }
                }
            

                else if (boxIndex == 20)
                {
                    if (tilePositions[boxIndex].GetComponent<BoxCheck>().boxChecked == false)
                    {
                        tilePositions[boxIndex].GetComponent<BoxCheck>().boxChecked = true; // setting the box on that position to being used
                        Debug.Log(tilePositions[boxIndex].GetComponent<BoxCheck>().boxChecked); // adding a debug to make sure it's working
                        RedPins[20].SetActive(true); // make the red pin visible
                        pinCount++; // add the now visible pin to the int
                        Debug.Log(pinCount); // debug to check how many pins I currently am storing in the pin count int
                    }
                }
            

                else if (boxIndex == 21)
                {
                    if (tilePositions[boxIndex].GetComponent<BoxCheck>().boxChecked == false)
                    {
                        tilePositions[boxIndex].GetComponent<BoxCheck>().boxChecked = true; // setting the box on that position to being used
                        Debug.Log(tilePositions[boxIndex].GetComponent<BoxCheck>().boxChecked); // adding a debug to make sure it's working
                        RedPins[21].SetActive(true); // make the red pin visible
                        pinCount++; // add the now visible pin to the int
                        Debug.Log(pinCount); // debug to check how many pins I currently am storing in the pin count int
                    }
                }
            

                else if (boxIndex == 22)
                {
                    if (tilePositions[boxIndex].GetComponent<BoxCheck>().boxChecked == false)
                    {
                        tilePositions[boxIndex].GetComponent<BoxCheck>().boxChecked = true; // setting the box on that position to being used
                        Debug.Log(tilePositions[boxIndex].GetComponent<BoxCheck>().boxChecked); // adding a debug to make sure it's working
                        RedPins[22].SetActive(true); // make the red pin visible
                        pinCount++; // add the now visible pin to the int
                        Debug.Log(pinCount); // debug to check how many pins I currently am storing in the pin count int
                    }
                }
            

                else if (boxIndex == 23)
                {
                    if (tilePositions[boxIndex].GetComponent<BoxCheck>().boxChecked == false)
                    {
                        tilePositions[boxIndex].GetComponent<BoxCheck>().boxChecked = true; // setting the box on that position to being used
                        Debug.Log(tilePositions[boxIndex].GetComponent<BoxCheck>().boxChecked); // adding a debug to make sure it's working
                        RedPins[23].SetActive(true); // make the red pin visible
                        pinCount++; // add the now visible pin to the int
                        Debug.Log(pinCount); // debug to check how many pins I currently am storing in the pin count int
                    }
                }
            

                else if (boxIndex == 24)
                {
                    if (tilePositions[boxIndex].GetComponent<BoxCheck>().boxChecked == false)
                    {
                        tilePositions[boxIndex].GetComponent<BoxCheck>().boxChecked = true; // setting the box on that position to being used
                        Debug.Log(tilePositions[boxIndex].GetComponent<BoxCheck>().boxChecked); // adding a debug to make sure it's working
                        RedPins[24].SetActive(true); // make the red pin visible
                        pinCount++; // add the now visible pin to the int
                        Debug.Log(pinCount); // debug to check how many pins I currently am storing in the pin count int
                    }
                }
        }
    }
}
