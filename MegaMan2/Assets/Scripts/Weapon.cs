using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*Name: Lyndon Jones
 *Date: 1/17/18
 *Credit: Project & Portfolio 4 - MegaMan 2 group project
 *Purpose: Instantiates bullet prefab                                  */
public class Weapon : MonoBehaviour {

    public GameObject bullet;

    private PlayerController playerMovement;


	// Use this for initialization
	void Start ()
    {
        playerMovement = GetComponent<PlayerController>();	
	}
	
	//Instantiates the bullets
	void Update ()
    {

        if (Input.GetKeyDown(KeyCode.K))
        {
            var tBullet = Instantiate(bullet, gameObject.transform.position, bullet.transform.rotation) as GameObject;
            tBullet.GetComponent<Bullet>().bulletDirection = playerMovement.PlayerDirection;
           
        }
        	
	}
}
