using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinCountScript : MonoBehaviour {

    public Text countText;
    private int count; //integer to store number of pins we have left

	// Use this for initialization
	void Start () {
        //initialize count to 9
        count = 9;
        //make the text continuously flash
        InvokeRepeating("FlashingText", 0f, 0.14f);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("RedPin"))
            count = count - 1;

        SetCountText();
    }

    void SetCountText()
    {
        countText.text = "" + count.ToString();
        //Check if we have any red pins left
        if(count <= 0)
        { //if we don't, then remove the text
            countText.SetActive(false);
        }
    }
    //make the text flash
    void FlashingText()
    {
        if (countText.SetActive(true))
        {
            countText.SetActive(false);
        }
        else if (countText.SetActive(false))
        {
            countText.SetActive(true);
        }
    }
}
