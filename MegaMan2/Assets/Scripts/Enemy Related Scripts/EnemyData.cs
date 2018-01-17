using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyData : MonoBehaviour
{
    //Variables
    [SerializeField] int strength;
    [SerializeField] int health;
    [SerializeField] float moveSpeed;
    [SerializeField] Transform target;

    [SerializeField] Camera mainCam;
    [SerializeField] bool cameraCanSee = false;

    private Animator animator;
    private float distanceToCamX;
    private float distanceToCamY;

    //Accessors
    public int Strength
    {
        get { return strength; }

        set{strength = value;}
    }

    public int Health
    {
        get { return health; }

        set { health = value; }
    }

    public Transform Target
    {
        get { return target; }

        set { target = value; }
    }

    public Camera MainCam
    {
        get { return mainCam; }

        set { mainCam = value; }
    }

    public bool CameraCanSee
    {
        get { return cameraCanSee; }

        set { cameraCanSee = value; }
    }

    public Animator Animator
    {
        get { return animator; }

        set { animator = value; }
    }

    public float MoveSpeed
    {
        get { return moveSpeed; }

        set { moveSpeed = value; }
    }

    public float DistanceToCamX
    {
        get { return distanceToCamX; }

        set { distanceToCamX = value; }
    }

    public float DistanceToCamY
    {
        get { return distanceToCamY; }

        set { distanceToCamY = value; }
    }

    // Use this for initialization
    void Start()
    {
        mainCam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        distanceToCamX = mainCam.transform.position.x - gameObject.transform.position.x;
        distanceToCamY = mainCam.transform.position.y - gameObject.transform.position.y;
    }
}
