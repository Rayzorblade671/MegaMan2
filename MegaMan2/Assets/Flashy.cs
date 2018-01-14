using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashy : MonoBehaviour {

	// Use this for initialization
	void Start () {
        InvokeRepeating("TileSelect", 0f, 0.14f);
    }

    void TileSelect()
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
