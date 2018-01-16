using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PasswordScript : MonoBehaviour {

    //[SerializeField] Transform selectBoss; // this holds the SelectBoss prefab that shows the player what's highlighted
    public GameObject[] RedPins; // array that holds all the red pin locations
    public GameObject[] tilePositions; // array that holds all the grid space positions
    Transform curPosition; // my current position Transform
    [SerializeField] bool boxUsed = false; // a bool to check if the Box is currently being used so that I can't press Enter twice
    private int pinCount = 0; // the int that counts how many pins I have on the board

    // Use this for initialization
    void Start () {
        curPosition = tilePositions[0].GetComponent<Transform>(); // setting my starting position to tile A1
        //selectBoss = tilePositions[0].GetComponent<Transform>(); // setting the SelectBoss prefab to go where the curPosition is
    }
	
	// Update is called once per frame
	void Update () {
        BoxSelection(); //calling the functions every frame
        BoxMarked();
	}

    private void BoxSelection()
    { //If i press D while on tile A1, move to tile A2. The debug checks to see which tile in the array I'm on
        if (Input.GetKeyDown(KeyCode.D) && curPosition == tilePositions[0].GetComponent<Transform>())
        {
            curPosition = tilePositions[1].GetComponent<Transform>();
            //selectBoss.Transform.position = curPosition;
            Debug.Log(curPosition);
        }

        else if (Input.GetKeyDown(KeyCode.S) && curPosition == tilePositions[0].GetComponent<Transform>())
        {
            curPosition = tilePositions[5].GetComponent<Transform>();
            Debug.Log(curPosition);
        }

// Tile A2
        else if (Input.GetKeyDown(KeyCode.A) && curPosition == tilePositions[1].GetComponent<Transform>())
        {
            curPosition = tilePositions[0].GetComponent<Transform>();
            Debug.Log(curPosition);
        }

        else if (Input.GetKeyDown(KeyCode.S) && curPosition == tilePositions[1].GetComponent<Transform>())
        {
            curPosition = tilePositions[6].GetComponent<Transform>();
            Debug.Log(curPosition);
        }

        else if (Input.GetKeyDown(KeyCode.D) && curPosition == tilePositions[1].GetComponent<Transform>())
        {
            curPosition = tilePositions[2].GetComponent<Transform>();
            Debug.Log(curPosition);
        }

// Tile A3
        else if (Input.GetKeyDown(KeyCode.A) && curPosition == tilePositions[2].GetComponent<Transform>())
        {
            curPosition = tilePositions[1].GetComponent<Transform>();
            Debug.Log(curPosition);
        }

        else if (Input.GetKeyDown(KeyCode.S) && curPosition == tilePositions[2].GetComponent<Transform>())
        {
            curPosition = tilePositions[7].GetComponent<Transform>();
            Debug.Log(curPosition);
        }

        else if (Input.GetKeyDown(KeyCode.D) && curPosition == tilePositions[2].GetComponent<Transform>())
        {
            curPosition = tilePositions[3].GetComponent<Transform>();
            Debug.Log(curPosition);
        }

// Tile A4
        else if (Input.GetKeyDown(KeyCode.A) && curPosition == tilePositions[3].GetComponent<Transform>())
        {
            curPosition = tilePositions[2].GetComponent<Transform>();
            Debug.Log(curPosition);
        }

        else if (Input.GetKeyDown(KeyCode.S) && curPosition == tilePositions[3].GetComponent<Transform>())
        {
            curPosition = tilePositions[8].GetComponent<Transform>();
            Debug.Log(curPosition);
        }

        else if (Input.GetKeyDown(KeyCode.D) && curPosition == tilePositions[3].GetComponent<Transform>())
        {
            curPosition = tilePositions[4].GetComponent<Transform>();
            Debug.Log(curPosition);
        }

// Tile A5
        else if (Input.GetKeyDown(KeyCode.A) && curPosition == tilePositions[4].GetComponent<Transform>())
        {
            curPosition = tilePositions[3].GetComponent<Transform>();
            Debug.Log(curPosition);
        }

        else if (Input.GetKeyDown(KeyCode.S) && curPosition == tilePositions[4].GetComponent<Transform>())
        {
            curPosition = tilePositions[9].GetComponent<Transform>();
            Debug.Log(curPosition);
        }

// Tile B1
        else if (Input.GetKeyDown(KeyCode.A) && curPosition == tilePositions[5].GetComponent<Transform>())
        {
            curPosition = tilePositions[0].GetComponent<Transform>();
            Debug.Log(curPosition);
        }

        else if (Input.GetKeyDown(KeyCode.D) && curPosition == tilePositions[5].GetComponent<Transform>())
        {
            curPosition = tilePositions[6].GetComponent<Transform>();
            Debug.Log(curPosition);
        }

        else if (Input.GetKeyDown(KeyCode.S) && curPosition == tilePositions[5].GetComponent<Transform>())
        {
            curPosition = tilePositions[10].GetComponent<Transform>();
            Debug.Log(curPosition);
        }

// Tile B2
        else if (Input.GetKeyDown(KeyCode.A) && curPosition == tilePositions[6].GetComponent<Transform>())
        {
            curPosition = tilePositions[5].GetComponent<Transform>();
            Debug.Log(curPosition);
        }

        else if (Input.GetKeyDown(KeyCode.D) && curPosition == tilePositions[6].GetComponent<Transform>())
        {
            curPosition = tilePositions[7].GetComponent<Transform>();
            Debug.Log(curPosition);
        }

        else if (Input.GetKeyDown(KeyCode.S) && curPosition == tilePositions[6].GetComponent<Transform>())
        {
            curPosition = tilePositions[11].GetComponent<Transform>();
            Debug.Log(curPosition);
        }

        else if (Input.GetKeyDown(KeyCode.W) && curPosition == tilePositions[6].GetComponent<Transform>())
        {
            curPosition = tilePositions[1].GetComponent<Transform>();
            Debug.Log(curPosition);
        }

// Tile B3
        else if (Input.GetKeyDown(KeyCode.A) && curPosition == tilePositions[7].GetComponent<Transform>())
        {
            curPosition = tilePositions[6].GetComponent<Transform>();
            Debug.Log(curPosition);
        }

        else if (Input.GetKeyDown(KeyCode.D) && curPosition == tilePositions[7].GetComponent<Transform>())
        {
            curPosition = tilePositions[8].GetComponent<Transform>();
            Debug.Log(curPosition);
        }

        else if (Input.GetKeyDown(KeyCode.S) && curPosition == tilePositions[7].GetComponent<Transform>())
        {
            curPosition = tilePositions[12].GetComponent<Transform>();
            Debug.Log(curPosition);
        }

        else if (Input.GetKeyDown(KeyCode.W) && curPosition == tilePositions[7].GetComponent<Transform>())
        {
            curPosition = tilePositions[2].GetComponent<Transform>();
            Debug.Log(curPosition);
        }

// Tile B4
        else if (Input.GetKeyDown(KeyCode.A) && curPosition == tilePositions[8].GetComponent<Transform>())
        {
            curPosition = tilePositions[7].GetComponent<Transform>();
            Debug.Log(curPosition);
        }

        else if (Input.GetKeyDown(KeyCode.D) && curPosition == tilePositions[8].GetComponent<Transform>())
        {
            curPosition = tilePositions[9].GetComponent<Transform>();
            Debug.Log(curPosition);
        }

        else if (Input.GetKeyDown(KeyCode.S) && curPosition == tilePositions[8].GetComponent<Transform>())
        {
            curPosition = tilePositions[13].GetComponent<Transform>();
            Debug.Log(curPosition);
        }

        else if (Input.GetKeyDown(KeyCode.W) && curPosition == tilePositions[8].GetComponent<Transform>())
        {
            curPosition = tilePositions[3].GetComponent<Transform>();
            Debug.Log(curPosition);
        }

// Tile B5
        else if (Input.GetKeyDown(KeyCode.A) && curPosition == tilePositions[9].GetComponent<Transform>())
        {
            curPosition = tilePositions[8].GetComponent<Transform>();
            Debug.Log(curPosition);
        }

        else if (Input.GetKeyDown(KeyCode.S) && curPosition == tilePositions[9].GetComponent<Transform>())
        {
            curPosition = tilePositions[14].GetComponent<Transform>();
            Debug.Log(curPosition);
        }

        else if (Input.GetKeyDown(KeyCode.W) && curPosition == tilePositions[9].GetComponent<Transform>())
        {
            curPosition = tilePositions[4].GetComponent<Transform>();
            Debug.Log(curPosition);
        }

// Tile C1
        else if (Input.GetKeyDown(KeyCode.D) && curPosition == tilePositions[10].GetComponent<Transform>())
        {
            curPosition = tilePositions[11].GetComponent<Transform>();
            Debug.Log(curPosition);
        }

        else if (Input.GetKeyDown(KeyCode.S) && curPosition == tilePositions[10].GetComponent<Transform>())
        {
            curPosition = tilePositions[15].GetComponent<Transform>();
            Debug.Log(curPosition);
        }

        else if (Input.GetKeyDown(KeyCode.W) && curPosition == tilePositions[10].GetComponent<Transform>())
        {
            curPosition = tilePositions[5].GetComponent<Transform>();
            Debug.Log(curPosition);
        }

// Tile C2
        else if (Input.GetKeyDown(KeyCode.A) && curPosition == tilePositions[11].GetComponent<Transform>())
        {
            curPosition = tilePositions[10].GetComponent<Transform>();
            Debug.Log(curPosition);
        }

        else if (Input.GetKeyDown(KeyCode.D) && curPosition == tilePositions[11].GetComponent<Transform>())
        {
            curPosition = tilePositions[12].GetComponent<Transform>();
            Debug.Log(curPosition);
        }

        else if (Input.GetKeyDown(KeyCode.S) && curPosition == tilePositions[11].GetComponent<Transform>())
        {
            curPosition = tilePositions[16].GetComponent<Transform>();
            Debug.Log(curPosition);
        }

        else if (Input.GetKeyDown(KeyCode.W) && curPosition == tilePositions[11].GetComponent<Transform>())
        {
            curPosition = tilePositions[6].GetComponent<Transform>();
            Debug.Log(curPosition);
        }

// Tile C3
        else if (Input.GetKeyDown(KeyCode.A) && curPosition == tilePositions[12].GetComponent<Transform>())
        {
            curPosition = tilePositions[11].GetComponent<Transform>();
            Debug.Log(curPosition);
        }

        else if (Input.GetKeyDown(KeyCode.D) && curPosition == tilePositions[12].GetComponent<Transform>())
        {
            curPosition = tilePositions[13].GetComponent<Transform>();
            Debug.Log(curPosition);
        }

        else if (Input.GetKeyDown(KeyCode.S) && curPosition == tilePositions[12].GetComponent<Transform>())
        {
            curPosition = tilePositions[17].GetComponent<Transform>();
            Debug.Log(curPosition);
        }

        else if (Input.GetKeyDown(KeyCode.W) && curPosition == tilePositions[12].GetComponent<Transform>())
        {
            curPosition = tilePositions[7].GetComponent<Transform>();
            Debug.Log(curPosition);
        }

// Tile C4
        else if (Input.GetKeyDown(KeyCode.A) && curPosition == tilePositions[13].GetComponent<Transform>())
        {
            curPosition = tilePositions[12].GetComponent<Transform>();
            Debug.Log(curPosition);
        }

        else if (Input.GetKeyDown(KeyCode.D) && curPosition == tilePositions[13].GetComponent<Transform>())
        {
            curPosition = tilePositions[14].GetComponent<Transform>();
            Debug.Log(curPosition);
        }

        else if (Input.GetKeyDown(KeyCode.S) && curPosition == tilePositions[13].GetComponent<Transform>())
        {
            curPosition = tilePositions[18].GetComponent<Transform>();
            Debug.Log(curPosition);
        }

        else if (Input.GetKeyDown(KeyCode.W) && curPosition == tilePositions[13].GetComponent<Transform>())
        {
            curPosition = tilePositions[8].GetComponent<Transform>();
            Debug.Log(curPosition);
        }

// Tile C5
        else if (Input.GetKeyDown(KeyCode.A) && curPosition == tilePositions[14].GetComponent<Transform>())
        {
            curPosition = tilePositions[13].GetComponent<Transform>();
            Debug.Log(curPosition);
        }

        else if (Input.GetKeyDown(KeyCode.S) && curPosition == tilePositions[14].GetComponent<Transform>())
        {
            curPosition = tilePositions[19].GetComponent<Transform>();
            Debug.Log(curPosition);
        }

        else if (Input.GetKeyDown(KeyCode.W) && curPosition == tilePositions[14].GetComponent<Transform>())
        {
            curPosition = tilePositions[9].GetComponent<Transform>();
            Debug.Log(curPosition);
        }

// Tile D1
        else if (Input.GetKeyDown(KeyCode.D) && curPosition == tilePositions[15].GetComponent<Transform>())
        {
            curPosition = tilePositions[16].GetComponent<Transform>();
            Debug.Log(curPosition);
        }

        else if (Input.GetKeyDown(KeyCode.S) && curPosition == tilePositions[15].GetComponent<Transform>())
        {
            curPosition = tilePositions[20].GetComponent<Transform>();
            Debug.Log(curPosition);
        }

        else if (Input.GetKeyDown(KeyCode.W) && curPosition == tilePositions[15].GetComponent<Transform>())
        {
            curPosition = tilePositions[10].GetComponent<Transform>();
            Debug.Log(curPosition);
        }
        
// Tile D2
        else if (Input.GetKeyDown(KeyCode.A) && curPosition == tilePositions[16].GetComponent<Transform>())
        {
            curPosition = tilePositions[15].GetComponent<Transform>();
            Debug.Log(curPosition);
        }

        else if (Input.GetKeyDown(KeyCode.D) && curPosition == tilePositions[16].GetComponent<Transform>())
        {
            curPosition = tilePositions[17].GetComponent<Transform>();
            Debug.Log(curPosition);
        }

        else if (Input.GetKeyDown(KeyCode.S) && curPosition == tilePositions[16].GetComponent<Transform>())
        {
            curPosition = tilePositions[21].GetComponent<Transform>();
            Debug.Log(curPosition);
        }

        else if (Input.GetKeyDown(KeyCode.W) && curPosition == tilePositions[16].GetComponent<Transform>())
        {
            curPosition = tilePositions[11].GetComponent<Transform>();
            Debug.Log(curPosition);
        }

// Tile D3
        else if (Input.GetKeyDown(KeyCode.A) && curPosition == tilePositions[17].GetComponent<Transform>())
        {
            curPosition = tilePositions[16].GetComponent<Transform>();
            Debug.Log(curPosition);
        }

        else if (Input.GetKeyDown(KeyCode.D) && curPosition == tilePositions[17].GetComponent<Transform>())
        {
            curPosition = tilePositions[18].GetComponent<Transform>();
            Debug.Log(curPosition);
        }

        else if (Input.GetKeyDown(KeyCode.S) && curPosition == tilePositions[17].GetComponent<Transform>())
        {
            curPosition = tilePositions[22].GetComponent<Transform>();
            Debug.Log(curPosition);
        }

        else if (Input.GetKeyDown(KeyCode.W) && curPosition == tilePositions[17].GetComponent<Transform>())
        {
            curPosition = tilePositions[12].GetComponent<Transform>();
            Debug.Log(curPosition);
        }

// Tile D4
        else if (Input.GetKeyDown(KeyCode.A) && curPosition == tilePositions[18].GetComponent<Transform>())
        {
            curPosition = tilePositions[17].GetComponent<Transform>();
            Debug.Log(curPosition);
        }

        else if (Input.GetKeyDown(KeyCode.D) && curPosition == tilePositions[18].GetComponent<Transform>())
        {
            curPosition = tilePositions[19].GetComponent<Transform>();
            Debug.Log(curPosition);
        }

        else if (Input.GetKeyDown(KeyCode.S) && curPosition == tilePositions[18].GetComponent<Transform>())
        {
            curPosition = tilePositions[23].GetComponent<Transform>();
            Debug.Log(curPosition);
        }

        else if (Input.GetKeyDown(KeyCode.W) && curPosition == tilePositions[18].GetComponent<Transform>())
        {
            curPosition = tilePositions[13].GetComponent<Transform>();
            Debug.Log(curPosition);
        }

// Tile D5
        else if (Input.GetKeyDown(KeyCode.A) && curPosition == tilePositions[19].GetComponent<Transform>())
        {
            curPosition = tilePositions[18].GetComponent<Transform>();
            Debug.Log(curPosition);
        }

        else if (Input.GetKeyDown(KeyCode.S) && curPosition == tilePositions[19].GetComponent<Transform>())
        {
            curPosition = tilePositions[24].GetComponent<Transform>();
            Debug.Log(curPosition);
        }

        else if (Input.GetKeyDown(KeyCode.W) && curPosition == tilePositions[19].GetComponent<Transform>())
        {
            curPosition = tilePositions[14].GetComponent<Transform>();
            Debug.Log(curPosition);
        }

// Tile E1
        else if (Input.GetKeyDown(KeyCode.D) && curPosition == tilePositions[20].GetComponent<Transform>())
        {
            curPosition = tilePositions[21].GetComponent<Transform>();
            Debug.Log(curPosition);
        }

        else if (Input.GetKeyDown(KeyCode.W) && curPosition == tilePositions[20].GetComponent<Transform>())
        {
            curPosition = tilePositions[15].GetComponent<Transform>();
            Debug.Log(curPosition);
        }

// Tile E2
        else if (Input.GetKeyDown(KeyCode.A) && curPosition == tilePositions[21].GetComponent<Transform>())
        {
            curPosition = tilePositions[18].GetComponent<Transform>();
            Debug.Log(curPosition);
        }

        else if (Input.GetKeyDown(KeyCode.D) && curPosition == tilePositions[21].GetComponent<Transform>())
        {
            curPosition = tilePositions[24].GetComponent<Transform>();
            Debug.Log(curPosition);
        }

        else if (Input.GetKeyDown(KeyCode.W) && curPosition == tilePositions[21].GetComponent<Transform>())
        {
            curPosition = tilePositions[14].GetComponent<Transform>();
            Debug.Log(curPosition);
        }
    }

    private void BoxMarked()
    { // check statement for when I press Enter to see if I'm on tile A1, and the box ISN'T used
        // if not being used, set it to being used, place a red pin, and add the pin to the pin count
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (curPosition == tilePositions[0].GetComponent<Transform>() && tilePositions[0].GetComponent<BoxCheck>().boxChecked == false)
            {
                tilePositions[0].GetComponent<BoxCheck>().boxChecked = true;
                Debug.Log(tilePositions[0].GetComponent<BoxCheck>().boxChecked);
                RedPins[0].SetActive(true);
                pinCount++;
                Debug.Log(pinCount);
            }
        }
    }
}
