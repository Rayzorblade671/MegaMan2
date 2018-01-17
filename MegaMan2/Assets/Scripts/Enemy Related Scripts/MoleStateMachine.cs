using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MoleStateMachine : MonoBehaviour
{
    private bool movingUp = true;

    //StateMachine Setup ---------------------------------------------------------------------
    private EnemyData enemyData;

    Dictionary<MoleStates, Action> msm = new Dictionary<MoleStates, Action>();

    enum MoleStates
    {
        ALIVE,
        DEAD
    }

    private MoleStates currentState = MoleStates.ALIVE;

    void SetState(MoleStates newState)
    {
        currentState = newState;
    }

    // Use this for initialization
    void Start()
    {
        enemyData = GetComponent<EnemyData>();

        enemyData.Health = 3;

        msm.Add(MoleStates.ALIVE, new Action(AliveState));
        msm.Add(MoleStates.DEAD, new Action(DeadState));
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < enemyData.MainCam.transform.position.y)
            movingUp = true;
        if (transform.position.y > enemyData.MainCam.transform.position.y)
            movingUp = false;

        if (movingUp)
            MoveUp();
        else
            MoveDown();

        msm[currentState].Invoke();
    }

    void MoveUp()
    {
        movingUp = true;
    }

    void MoveDown()
    {

    }

    //States -----------------------------------------------------------------------------
    void AliveState()
    {
        if (enemyData.DistanceToCamX >= 16 || enemyData.DistanceToCamX <= -16)
        {
            SetState(MoleStates.DEAD);
        }
    }

    void DeadState()
    {
        GameObject.Destroy(gameObject);
    }
}
