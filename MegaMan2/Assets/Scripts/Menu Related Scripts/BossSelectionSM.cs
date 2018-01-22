using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

/*
 * Name - Kaitlin Soter
 * 1/17/2018
 * Credit: Project & Portfolio 4 - Mega Man 2 group project
 * Purpose: Contains movement for SelectBoss prefab, and sends player to appropriate level
 */

public class BossSelectionSM : MonoBehaviour {

    private BossSelection bossScript;
    

    enum tileStates
    {
        Bubble,
        Air,
        Quick,
        Heat,
        Wily,
        Wood,
        Metal,
        Flash,
        Crash
    }

    tileStates curState = tileStates.Bubble;

    Dictionary<tileStates, Action> fsm = new Dictionary<tileStates, Action>();
    //tileStates curState = tileStates.Wily;
	// Use this for initialization
	void Start () { 

        bossScript = GameObject.Find("SelectBoss").GetComponent<BossSelection>();

        fsm.Add(tileStates.Bubble, BubbleState);
        fsm.Add(tileStates.Air, AirState);
        fsm.Add(tileStates.Quick, QuickState);
        fsm.Add(tileStates.Heat, HeatState);
        fsm.Add(tileStates.Wily, WilyState);
        fsm.Add(tileStates.Wood, WoodState);
        fsm.Add(tileStates.Metal, MetalState);
        fsm.Add(tileStates.Flash, FlashState);
        fsm.Add(tileStates.Crash, CrashState);
    }
	
	// Update is called once per frame
	void Update () {
        fsm[curState].Invoke();

        if(curState == tileStates.Bubble)
        {
            BubbleState();
        }

        else if (curState == tileStates.Air)
        {
            AirState();
        }

        else if (curState == tileStates.Quick)
        {
            QuickState();
        }

        else if (curState == tileStates.Heat)
        {
            HeatState();
        }

        else if (curState == tileStates.Wily)
        {
            WilyState();
        }

        else if (curState == tileStates.Wood)
        {
            WoodState();
        }

        else if (curState == tileStates.Metal)
        {
            MetalState();
        }

        else if (curState == tileStates.Flash)
        {
            FlashState();
        }

        else if (curState == tileStates.Crash)
        {
            CrashState();
        }
    }

    void SetState(tileStates newState)
    {
        curState = newState;
    }

    void BubbleState()
    {
        if(BossSelection.instance.timerMaximum <= BossSelection.instance.timerHitMaximum)
        {
            BossSelection.instance.BubbleMan();
            if (Input.GetKeyDown(KeyCode.D))
            {
                BossSelection.instance.AirMan();
                SetState(tileStates.Air);
                BossSelection.instance.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.S))
            {
                BossSelection.instance.HeatMan();
                SetState(tileStates.Heat);
                BossSelection.instance.ResetTimer();
            }
        }
    }

    void AirState()
    {
        if (BossSelection.instance.timerMaximum <= BossSelection.instance.timerHitMaximum)
        {
            BossSelection.instance.AirMan();
            if (Input.GetKeyDown(KeyCode.D))
            {
                BossSelection.instance.QuickMan();
                SetState(tileStates.Quick);
                BossSelection.instance.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.A))
            {
                BossSelection.instance.BubbleMan();
                SetState(tileStates.Bubble);
                BossSelection.instance.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.S))
            {
                BossSelection.instance.DrWily();
                SetState(tileStates.Wily);
                BossSelection.instance.ResetTimer();
            }
        }
    }
    void QuickState()
    {
        if (BossSelection.instance.timerMaximum <= BossSelection.instance.timerHitMaximum)
        {
            BossSelection.instance.QuickMan();
            if (Input.GetKeyDown(KeyCode.S))
            {
                BossSelection.instance.WoodMan();
                SetState(tileStates.Wood);
                BossSelection.instance.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.A))
            {
                BossSelection.instance.AirMan();
                SetState(tileStates.Air);
                BossSelection.instance.ResetTimer();
            }
        }
    }
    void HeatState()
    {
        if (BossSelection.instance.timerMaximum <= BossSelection.instance.timerHitMaximum)
        {
            BossSelection.instance.HeatMan();
            if (Input.GetKeyDown(KeyCode.W))
            {
                BossSelection.instance.BubbleMan();
                SetState(tileStates.Bubble);
                BossSelection.instance.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                BossSelection.instance.DrWily();
                SetState(tileStates.Wily);
                BossSelection.instance.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.S))
            {
                BossSelection.instance.MetalMan();
                SetState(tileStates.Metal);
                BossSelection.instance.ResetTimer();
            }
        }
    }
    void WilyState()
    {
        if (BossSelection.instance.timerMaximum <= BossSelection.instance.timerHitMaximum)
        {
            BossSelection.instance.DrWily();
            if (Input.GetKeyDown(KeyCode.W))
            {
                BossSelection.instance.AirMan();
                SetState(tileStates.Air);
                BossSelection.instance.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                BossSelection.instance.WoodMan();
                SetState(tileStates.Wood);
                BossSelection.instance.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.A))
            {
                BossSelection.instance.HeatMan();
                SetState(tileStates.Heat);
                BossSelection.instance.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.S))
            {
                BossSelection.instance.FlashMan();
                SetState(tileStates.Flash);
                BossSelection.instance.ResetTimer();
            }
        }
    }
    void WoodState()
    {
        if (BossSelection.instance.timerMaximum <= BossSelection.instance.timerHitMaximum)
        {
            BossSelection.instance.WoodMan();
            if (Input.GetKeyDown(KeyCode.W))
            {
                BossSelection.instance.QuickMan();
                SetState(tileStates.Quick);
                BossSelection.instance.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.S))
            {
                BossSelection.instance.CrashMan();
                SetState(tileStates.Crash);
                BossSelection.instance.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.A))
            {
                BossSelection.instance.DrWily();
                SetState(tileStates.Wily);
                BossSelection.instance.ResetTimer();
            }
        }
    }
    void MetalState()
    {
        if (BossSelection.instance.timerMaximum <= BossSelection.instance.timerHitMaximum)
        {
            BossSelection.instance.MetalMan();
            if (Input.GetKeyDown(KeyCode.W))
            {
                BossSelection.instance.HeatMan();
                SetState(tileStates.Heat);
                BossSelection.instance.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                BossSelection.instance.FlashMan();
                SetState(tileStates.Flash);
                BossSelection.instance.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter))
            {
                SceneManager.LoadScene("TestScene");
            }
        }
    }
    void FlashState()
    {
        if (BossSelection.instance.timerMaximum <= BossSelection.instance.timerHitMaximum)
        {
            BossSelection.instance.FlashMan();
            if (Input.GetKeyDown(KeyCode.W))
            {
                BossSelection.instance.DrWily();
                SetState(tileStates.Wily);
                BossSelection.instance.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                BossSelection.instance.CrashMan();
                SetState(tileStates.Crash);
                BossSelection.instance.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.A))
            {
                BossSelection.instance.MetalMan();
                SetState(tileStates.Metal);
                BossSelection.instance.ResetTimer();
            }
        }
    }
    void CrashState()
    {
        if (BossSelection.instance.timerMaximum <= BossSelection.instance.timerHitMaximum)
        {
            BossSelection.instance.CrashMan();
            if (Input.GetKeyDown(KeyCode.W))
            {
                BossSelection.instance.WoodMan();
                SetState(tileStates.Wood);
                BossSelection.instance.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.A))
            {
                BossSelection.instance.FlashMan();
                SetState(tileStates.Flash);
                BossSelection.instance.ResetTimer();
            }
        }
    }
}
