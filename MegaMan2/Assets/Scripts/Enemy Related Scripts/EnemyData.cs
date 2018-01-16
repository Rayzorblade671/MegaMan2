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
    private float distanceToCam;

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

    public float DistanceToCam
    {
        get { return distanceToCam; }

        set { distanceToCam = value; }
    }

    // Use this for initialization
    void Start()
    {
        mainCam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        distanceToCam = mainCam.transform.position.x - gameObject.transform.position.x;
    }
}
