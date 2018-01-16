using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MoleStateMachine : MonoBehaviour
{
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
        msm[currentState].Invoke();
    }

    //States -----------------------------------------------------------------------------
    void AliveState()
    {
        if (enemyData.DistanceToCam >= 16 || enemyData.DistanceToCam <= -16)
        {
            SetState(MoleStates.DEAD);
        }
    }

    void DeadState()
    {
        GameObject.Destroy(gameObject);
    }
}
