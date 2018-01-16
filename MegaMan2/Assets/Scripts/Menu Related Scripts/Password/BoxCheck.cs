using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxCheck : MonoBehaviour {


    public bool boxChecked = false;

    public bool GetBoxChecked()
    {
        return boxChecked;
    }

    public void SetBoxChecked(bool value)
    {
        boxChecked = value;
    }


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
