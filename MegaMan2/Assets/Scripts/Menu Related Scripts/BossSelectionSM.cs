using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

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
        if(bossScript.timerMaximum <= bossScript.timerHitMaximum)
        {
            bossScript.BubbleMan();
            if (Input.GetKeyDown(KeyCode.D))
            {
                bossScript.AirMan();
                SetState(tileStates.Air);
                bossScript.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.S))
            {
                bossScript.HeatMan();
                SetState(tileStates.Heat);
                bossScript.ResetTimer();
            }
        }
    }

    void AirState()
    {
        if (bossScript.timerMaximum <= bossScript.timerHitMaximum)
        {
            bossScript.AirMan();
            if (Input.GetKeyDown(KeyCode.D))
            {
                bossScript.QuickMan();
                SetState(tileStates.Quick);
                bossScript.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.A))
            {
                bossScript.BubbleMan();
                SetState(tileStates.Bubble);
                bossScript.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.S))
            {
                bossScript.DrWily();
                SetState(tileStates.Wily);
                bossScript.ResetTimer();
            }
        }
    }
    void QuickState()
    {
        if (bossScript.timerMaximum <= bossScript.timerHitMaximum)
        {
            bossScript.QuickMan();
            if (Input.GetKeyDown(KeyCode.S))
            {
                bossScript.WoodMan();
                SetState(tileStates.Wood);
                bossScript.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.A))
            {
                bossScript.AirMan();
                SetState(tileStates.Air);
                bossScript.ResetTimer();
            }
        }
    }
    void HeatState()
    {
        if (bossScript.timerMaximum <= bossScript.timerHitMaximum)
        {
            bossScript.HeatMan();
            if (Input.GetKeyDown(KeyCode.W))
            {
                bossScript.BubbleMan();
                SetState(tileStates.Bubble);
                bossScript.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                bossScript.DrWily();
                SetState(tileStates.Wily);
                bossScript.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.S))
            {
                bossScript.MetalMan();
                SetState(tileStates.Metal);
                bossScript.ResetTimer();
            }
        }
    }
    void WilyState()
    {
        if (bossScript.timerMaximum <= bossScript.timerHitMaximum)
        {
            bossScript.DrWily();
            if (Input.GetKeyDown(KeyCode.W))
            {
                bossScript.AirMan();
                SetState(tileStates.Air);
                bossScript.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                bossScript.WoodMan();
                SetState(tileStates.Wood);
                bossScript.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.A))
            {
                bossScript.HeatMan();
                SetState(tileStates.Heat);
                bossScript.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.S))
            {
                bossScript.FlashMan();
                SetState(tileStates.Flash);
                bossScript.ResetTimer();
            }
        }
    }
    void WoodState()
    {
        if (bossScript.timerMaximum <= bossScript.timerHitMaximum)
        {
            bossScript.WoodMan();
            if (Input.GetKeyDown(KeyCode.W))
            {
                bossScript.QuickMan();
                SetState(tileStates.Quick);
                bossScript.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.S))
            {
                bossScript.CrashMan();
                SetState(tileStates.Crash);
                bossScript.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.A))
            {
                bossScript.DrWily();
                SetState(tileStates.Wily);
                bossScript.ResetTimer();
            }
        }
    }
    void MetalState()
    {
        if (bossScript.timerMaximum <= bossScript.timerHitMaximum)
        {
            bossScript.MetalMan();
            if (Input.GetKeyDown(KeyCode.W))
            {
                bossScript.HeatMan();
                SetState(tileStates.Heat);
                bossScript.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                bossScript.FlashMan();
                SetState(tileStates.Flash);
                bossScript.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.Return))
            {
                SceneManager.LoadScene("TestScene");
            }
        }
    }
    void FlashState()
    {
        if (bossScript.timerMaximum <= bossScript.timerHitMaximum)
        {
            bossScript.FlashMan();
            if (Input.GetKeyDown(KeyCode.W))
            {
                bossScript.DrWily();
                SetState(tileStates.Wily);
                bossScript.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                bossScript.CrashMan();
                SetState(tileStates.Crash);
                bossScript.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.A))
            {
                bossScript.MetalMan();
                SetState(tileStates.Metal);
                bossScript.ResetTimer();
            }
        }
    }
    void CrashState()
    {
        if (bossScript.timerMaximum <= bossScript.timerHitMaximum)
        {
            bossScript.CrashMan();
            if (Input.GetKeyDown(KeyCode.W))
            {
                bossScript.WoodMan();
                SetState(tileStates.Wood);
                bossScript.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.A))
            {
                bossScript.FlashMan();
                SetState(tileStates.Flash);
                bossScript.ResetTimer();
            }
        }
    }
}
