using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class PSStateMachine : MonoBehaviour {

    private PasswordSelection passSelect;

    enum STATES
    {
        TileA1,
        TileA2,
        TileA3,
        TileA4,
        TileA5,
        TileB1,
        TileB2,
        TileB3,
        TileB4,
        TileB5,
        TileC1,
        TileC2,
        TileC3,
        TileC4,
        TileC5,
        TileD1,
        TileD2,
        TileD3,
        TileD4,
        TileD5,
        TileE1,
        TileE2,
        TileE3,
        TileE4,
        TileE5,
    }

    STATES curState = STATES.TileA1;

    Dictionary<STATES, Action> fsm = new Dictionary<STATES, Action>();

	// Use this for initialization
	void Start () {
        passSelect = GameObject.Find("SelectBoss").GetComponent<PasswordSelection>();

        fsm.Add(STATES.TileA1, A1State);
        fsm.Add(STATES.TileA2, A2State);
        fsm.Add(STATES.TileA3, A3State);
        fsm.Add(STATES.TileA4, A4State);
        fsm.Add(STATES.TileA5, A5State);
        fsm.Add(STATES.TileB1, B1State);
        fsm.Add(STATES.TileB2, B2State);
        fsm.Add(STATES.TileB3, B3State);
        fsm.Add(STATES.TileB4, B4State);
        fsm.Add(STATES.TileB5, B5State);
        fsm.Add(STATES.TileC1, C1State);
        fsm.Add(STATES.TileC2, C2State);
        fsm.Add(STATES.TileC3, C3State);
        fsm.Add(STATES.TileC4, C4State);
        fsm.Add(STATES.TileC5, C5State);
        fsm.Add(STATES.TileD1, D1State);
        fsm.Add(STATES.TileD2, D2State);
        fsm.Add(STATES.TileD3, D3State);
        fsm.Add(STATES.TileD4, D4State);
        fsm.Add(STATES.TileD5, D5State);
        fsm.Add(STATES.TileE1, E1State);
        fsm.Add(STATES.TileE2, E2State);
        fsm.Add(STATES.TileE3, E3State);
        fsm.Add(STATES.TileE4, E4State);
        fsm.Add(STATES.TileE5, E5State);

    }
	
	// Update is called once per frame
	void Update () {

        fsm[curState].Invoke();

        if(curState == STATES.TileA1)
        {
            A1State();
        }

        else if (curState == STATES.TileA2)
        {
            A2State();
        }

        else if (curState == STATES.TileA3)
        {
            A3State();
        }

        else if (curState == STATES.TileA4)
        {
            A4State();
        }

        else if (curState == STATES.TileA5)
        {
            A5State();
        }

        else if (curState == STATES.TileB1)
        {
            B1State();
        }

        else if (curState == STATES.TileB2)
        {
            B2State();
        }

        else if (curState == STATES.TileB3)
        {
            B3State();
        }

        else if (curState == STATES.TileB4)
        {
            B4State();
        }

        else if (curState == STATES.TileB5)
        {
            B5State();
        }

        else if (curState == STATES.TileC1)
        {
            C1State();
        }

        else if (curState == STATES.TileC2)
        {
            C2State();
        }

        else if (curState == STATES.TileC3)
        {
            C3State();
        }

        else if (curState == STATES.TileC4)
        {
            C4State();
        }

        else if (curState == STATES.TileC5)
        {
            C5State();
        }

        else if (curState == STATES.TileD1)
        {
            D1State();
        }

        else if (curState == STATES.TileD2)
        {
            D2State();
        }

        else if (curState == STATES.TileD3)
        {
            D3State();
        }

        else if (curState == STATES.TileD4)
        {
            D4State();
        }

        else if (curState == STATES.TileD5)
        {
            D5State();
        }

        else if (curState == STATES.TileE1)
        {
            E1State();
        }

        else if (curState == STATES.TileE2)
        {
            E2State();
        }

        else if (curState == STATES.TileE3)
        {
            E3State();
        }

        else if (curState == STATES.TileE4)
        {
            E4State();
        }

        else if (curState == STATES.TileE5)
        {
            E5State();
        }
    }

    void SetState(STATES newState)
    {
        curState = newState;
    }

    void A1State()
    {
        if (passSelect.timerMaximum <= passSelect.timerHitMaximum)
        {
            passSelect.A1();
            if (Input.GetKeyDown(KeyCode.S))
            {
                passSelect.B1();
                SetState(STATES.TileB1);
                passSelect.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                passSelect.A2();
                SetState(STATES.TileA2);
                passSelect.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.Return))
            {
                Instantiate(GameObject.Find("Red Pin"), new Vector3(-4.17f, 1.73f, -0.3f), Quaternion.identity);
                passSelect.ResetTimer();
            }
        }
    }

    void A2State()
    {
        if (passSelect.timerMaximum <= passSelect.timerHitMaximum)
        {
            passSelect.A2();
            if (Input.GetKeyDown(KeyCode.S))
            {
                passSelect.B2();
                SetState(STATES.TileB2);
                passSelect.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                passSelect.A3();
                SetState(STATES.TileA3);
                passSelect.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.A))
            {
                passSelect.A1();
                SetState(STATES.TileA1);
                passSelect.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.Return))
            {
                Instantiate(GameObject.Find("Red Pin"), new Vector3(-3.56f, 1.73f, -0.3f), Quaternion.identity);
                passSelect.ResetTimer();
            }
        }
    }

    void A3State()
    {
        if (passSelect.timerMaximum <= passSelect.timerHitMaximum)
        {
            passSelect.A3();
            if (Input.GetKeyDown(KeyCode.S))
            {
                passSelect.B3();
                SetState(STATES.TileB3);
                passSelect.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                passSelect.A4();
                SetState(STATES.TileA4);
                passSelect.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.A))
            {
                passSelect.A2();
                SetState(STATES.TileA2);
                passSelect.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.Return))
            {
                Instantiate(GameObject.Find("Red Pin"), new Vector3(-2.97f, 1.73f, -0.3f), Quaternion.identity);
                passSelect.ResetTimer();
            }
        }
    }

    void A4State()
    {
        if (passSelect.timerMaximum <= passSelect.timerHitMaximum)
        {
            passSelect.A4();
            if (Input.GetKeyDown(KeyCode.S))
            {
                passSelect.B4();
                SetState(STATES.TileB4);
                passSelect.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                passSelect.A5();
                SetState(STATES.TileA5);
                passSelect.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.A))
            {
                passSelect.A3();
                SetState(STATES.TileA3);
                passSelect.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.Return))
            {
                Instantiate(GameObject.Find("Red Pin"), new Vector3(-2.36f, 1.73f, -0.3f), Quaternion.identity);
                passSelect.ResetTimer();
            }
        }
    }

    void A5State()
    {
        if (passSelect.timerMaximum <= passSelect.timerHitMaximum)
        {
            passSelect.A5();
            if (Input.GetKeyDown(KeyCode.S))
            {
                passSelect.B5();
                SetState(STATES.TileB5);
                passSelect.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.A))
            {
                passSelect.A4();
                SetState(STATES.TileA4);
                passSelect.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.Return))
            {
                Instantiate(GameObject.Find("Red Pin"), new Vector3(-1.76f, 1.73f, -0.3f), Quaternion.identity);
                passSelect.ResetTimer();
            }
        }
    }

    void B1State()
    {
        if (passSelect.timerMaximum <= passSelect.timerHitMaximum)
        {
            passSelect.B1();
            if (Input.GetKeyDown(KeyCode.S))
            {
                passSelect.C1();
                SetState(STATES.TileC1);
                passSelect.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                passSelect.B2();
                SetState(STATES.TileB2);
                passSelect.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.W))
            {
                passSelect.A1();
                SetState(STATES.TileA1);
                passSelect.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.Return))
            {
                Instantiate(GameObject.Find("Red Pin"), new Vector3(-4.17f, 1.12f, -0.3f), Quaternion.identity);
                passSelect.ResetTimer();
            }
        }
    }

    void B2State()
    {
        if (passSelect.timerMaximum <= passSelect.timerHitMaximum)
        {
            passSelect.B2();
            if (Input.GetKeyDown(KeyCode.S))
            {
                passSelect.C2();
                SetState(STATES.TileC2);
                passSelect.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                passSelect.B3();
                SetState(STATES.TileB3);
                passSelect.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.A))
            {
                passSelect.B1();
                SetState(STATES.TileB1);
                passSelect.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.W))
            {
                passSelect.A2();
                SetState(STATES.TileA2);
                passSelect.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.Return))
            {
                Instantiate(GameObject.Find("Red Pin"), new Vector3(-3.56f, 1.12f, -0.3f), Quaternion.identity);
                passSelect.ResetTimer();
            }
        }
    }

    void B3State()
    {
        if (passSelect.timerMaximum <= passSelect.timerHitMaximum)
        {
            passSelect.B3();
            if (Input.GetKeyDown(KeyCode.S))
            {
                passSelect.C3();
                SetState(STATES.TileC3);
                passSelect.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                passSelect.B4();
                SetState(STATES.TileB4);
                passSelect.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.A))
            {
                passSelect.B2();
                SetState(STATES.TileB2);
                passSelect.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.W))
            {
                passSelect.A3();
                SetState(STATES.TileA3);
                passSelect.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.Return))
            {
                Instantiate(GameObject.Find("Red Pin"), new Vector3(-2.97f, 1.12f, -0.3f), Quaternion.identity);
                passSelect.ResetTimer();
            }
        }
    }

    void B4State()
    {
        if (passSelect.timerMaximum <= passSelect.timerHitMaximum)
        {
            passSelect.B4();
            if (Input.GetKeyDown(KeyCode.S))
            {
                passSelect.C4();
                SetState(STATES.TileC4);
                passSelect.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                passSelect.B5();
                SetState(STATES.TileB5);
                passSelect.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.A))
            {
                passSelect.B3();
                SetState(STATES.TileB3);
                passSelect.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.W))
            {
                passSelect.A4();
                SetState(STATES.TileA4);
                passSelect.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.Return))
            {
                Instantiate(GameObject.Find("Red Pin"), new Vector3(-2.36f, 1.12f, -0.3f), Quaternion.identity);
                passSelect.ResetTimer();
            }
        }
    }

    void B5State()
    {
        if (passSelect.timerMaximum <= passSelect.timerHitMaximum)
        {
            passSelect.B5();
            if (Input.GetKeyDown(KeyCode.S))
            {
                passSelect.C5();
                SetState(STATES.TileC5);
                passSelect.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.A))
            {
                passSelect.B4();
                SetState(STATES.TileB4);
                passSelect.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.W))
            {
                passSelect.A5();
                SetState(STATES.TileA5);
                passSelect.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.Return))
            {
                Instantiate(GameObject.Find("Red Pin"), new Vector3(-1.76f, 1.12f, -0.3f), Quaternion.identity);
                passSelect.ResetTimer();
            }
        }
    }

    void C1State()
    {
        if (passSelect.timerMaximum <= passSelect.timerHitMaximum)
        {
            passSelect.C1();
            if (Input.GetKeyDown(KeyCode.S))
            {
                passSelect.D1();
                SetState(STATES.TileD1);
                passSelect.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                passSelect.C2();
                SetState(STATES.TileC2);
                passSelect.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.W))
            {
                passSelect.B1();
                SetState(STATES.TileB1);
                passSelect.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.Return))
            {
                Instantiate(GameObject.Find("Red Pin"), new Vector3(-4.17f, 0.5f, -0.3f), Quaternion.identity);
                passSelect.ResetTimer();
            }
        }
    }

    void C2State()
    {
        if (passSelect.timerMaximum <= passSelect.timerHitMaximum)
        {
            passSelect.C2();
            if (Input.GetKeyDown(KeyCode.S))
            {
                passSelect.D2();
                SetState(STATES.TileD2);
                passSelect.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                passSelect.C3();
                SetState(STATES.TileC3);
                passSelect.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.A))
            {
                passSelect.C1();
                SetState(STATES.TileC1);
                passSelect.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.W))
            {
                passSelect.B2();
                SetState(STATES.TileB2);
                passSelect.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.Return))
            {
                Instantiate(GameObject.Find("Red Pin"), new Vector3(-3.56f, 0.5f, -0.3f), Quaternion.identity);
                passSelect.ResetTimer();
            }
        }
    }

    void C3State()
    {
        if (passSelect.timerMaximum <= passSelect.timerHitMaximum)
        {
            passSelect.C3();
            if (Input.GetKeyDown(KeyCode.S))
            {
                passSelect.D3();
                SetState(STATES.TileD3);
                passSelect.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                passSelect.C4();
                SetState(STATES.TileC4);
                passSelect.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.A))
            {
                passSelect.C2();
                SetState(STATES.TileC2);
                passSelect.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.W))
            {
                passSelect.B3();
                SetState(STATES.TileB3);
                passSelect.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.Return))
            {
                Instantiate(GameObject.Find("Red Pin"), new Vector3(-2.97f, 0.5f, -0.3f), Quaternion.identity);
                passSelect.ResetTimer();
            }
        }
    }

    void C4State()
    {
        if (passSelect.timerMaximum <= passSelect.timerHitMaximum)
        {
            passSelect.C4();
            if (Input.GetKeyDown(KeyCode.S))
            {
                passSelect.D4();
                SetState(STATES.TileD4);
                passSelect.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                passSelect.C5();
                SetState(STATES.TileC5);
                passSelect.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.A))
            {
                passSelect.C3();
                SetState(STATES.TileC3);
                passSelect.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.W))
            {
                passSelect.B4();
                SetState(STATES.TileB4);
                passSelect.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.Return))
            {
                Instantiate(GameObject.Find("Red Pin"), new Vector3(-2.36f, 0.5f, -0.3f), Quaternion.identity);
                passSelect.ResetTimer();
            }
        }
    }

    void C5State()
    {
        if (passSelect.timerMaximum <= passSelect.timerHitMaximum)
        {
            passSelect.C5();
            if (Input.GetKeyDown(KeyCode.S))
            {
                passSelect.D5();
                SetState(STATES.TileD5);
                passSelect.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.A))
            {
                passSelect.C4();
                SetState(STATES.TileC4);
                passSelect.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.W))
            {
                passSelect.B5();
                SetState(STATES.TileB5);
                passSelect.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.Return))
            {
                Instantiate(GameObject.Find("Red Pin"), new Vector3(-1.76f, 0.5f, -0.3f), Quaternion.identity);
                passSelect.ResetTimer();
            }
        }
    }

    void D1State()
    {
        if (passSelect.timerMaximum <= passSelect.timerHitMaximum)
        {
            passSelect.D1();
            if (Input.GetKeyDown(KeyCode.S))
            {
                passSelect.E1();
                SetState(STATES.TileE1);
                passSelect.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                passSelect.D2();
                SetState(STATES.TileD2);
                passSelect.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.W))
            {
                passSelect.C1();
                SetState(STATES.TileC1);
                passSelect.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.Return))
            {
                Instantiate(GameObject.Find("Red Pin"), new Vector3(-4.17f, -0.13f, -0.3f), Quaternion.identity);
                passSelect.ResetTimer();
            }
        }
    }

    void D2State()
    {
        if (passSelect.timerMaximum <= passSelect.timerHitMaximum)
        {
            passSelect.D2();
            if (Input.GetKeyDown(KeyCode.S))
            {
                passSelect.E2();
                SetState(STATES.TileE2);
                passSelect.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                passSelect.D3();
                SetState(STATES.TileD3);
                passSelect.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.A))
            {
                passSelect.D1();
                SetState(STATES.TileD1);
                passSelect.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.W))
            {
                passSelect.C2();
                SetState(STATES.TileC2);
                passSelect.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.Return))
            {
                Instantiate(GameObject.Find("Red Pin"), new Vector3(-3.56f, -0.13f, -0.3f), Quaternion.identity);
                passSelect.ResetTimer();
            }
        }
    }

    void D3State()
    {
        if (passSelect.timerMaximum <= passSelect.timerHitMaximum)
        {
            passSelect.D3();
            if (Input.GetKeyDown(KeyCode.S))
            {
                passSelect.E3();
                SetState(STATES.TileE3);
                passSelect.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                passSelect.D4();
                SetState(STATES.TileD4);
                passSelect.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.A))
            {
                passSelect.D2();
                SetState(STATES.TileD2);
                passSelect.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.W))
            {
                passSelect.C3();
                SetState(STATES.TileC3);
                passSelect.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.Return))
            {
                Instantiate(GameObject.Find("Red Pin"), new Vector3(-2.97f, -0.13f, -0.3f), Quaternion.identity);
                passSelect.ResetTimer();
            }
        }
    }

    void D4State()
    {
        if (passSelect.timerMaximum <= passSelect.timerHitMaximum)
        {
            passSelect.D4();
            if (Input.GetKeyDown(KeyCode.S))
            {
                passSelect.E4();
                SetState(STATES.TileE4);
                passSelect.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                passSelect.D5();
                SetState(STATES.TileD5);
                passSelect.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.A))
            {
                passSelect.D3();
                SetState(STATES.TileD3);
                passSelect.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.W))
            {
                passSelect.C4();
                SetState(STATES.TileC4);
                passSelect.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.Return))
            {
                Instantiate(GameObject.Find("Red Pin"), new Vector3(-2.36f, -0.13f, -0.3f), Quaternion.identity);
                passSelect.ResetTimer();
            }
        }
    }

    void D5State()
    {
        if (passSelect.timerMaximum <= passSelect.timerHitMaximum)
        {
            passSelect.D5();
            if (Input.GetKeyDown(KeyCode.S))
            {
                passSelect.E5();
                SetState(STATES.TileE5);
                passSelect.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.A))
            {
                passSelect.D4();
                SetState(STATES.TileD4);
                passSelect.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.W))
            {
                passSelect.C5();
                SetState(STATES.TileC5);
                passSelect.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.Return))
            {
                Instantiate(GameObject.Find("Red Pin"), new Vector3(-1.76f, -0.13f, -0.3f), Quaternion.identity);
                passSelect.ResetTimer();
            }
        }
    }

    void E1State()
    {
        if (passSelect.timerMaximum <= passSelect.timerHitMaximum)
        {
            passSelect.E1();
            if (Input.GetKeyDown(KeyCode.D))
            {
                passSelect.E2();
                SetState(STATES.TileE2);
                passSelect.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.W))
            {
                passSelect.D1();
                SetState(STATES.TileD1);
                passSelect.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.Return))
            {
                Instantiate(GameObject.Find("Red Pin"), new Vector3(-4.17f, -0.75f, -0.3f), Quaternion.identity);
                passSelect.ResetTimer();
            }
        }
    }

    void E2State()
    {
        if (passSelect.timerMaximum <= passSelect.timerHitMaximum)
        {
            passSelect.E2();
            if (Input.GetKeyDown(KeyCode.D))
            {
                passSelect.E3();
                SetState(STATES.TileE3);
                passSelect.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.A))
            {
                passSelect.E1();
                SetState(STATES.TileE1);
                passSelect.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.W))
            {
                passSelect.D2();
                SetState(STATES.TileD2);
                passSelect.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.Return))
            {
                Instantiate(GameObject.Find("Red Pin"), new Vector3(-3.56f, -0.75f, -0.3f), Quaternion.identity);
                passSelect.ResetTimer();
            }
        }
    }

    void E3State()
    {
        if (passSelect.timerMaximum <= passSelect.timerHitMaximum)
        {
            passSelect.E3();
            if (Input.GetKeyDown(KeyCode.D))
            {
                passSelect.E4();
                SetState(STATES.TileE4);
                passSelect.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.A))
            {
                passSelect.E2();
                SetState(STATES.TileE2);
                passSelect.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.W))
            {
                passSelect.D3();
                SetState(STATES.TileD3);
                passSelect.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.Return))
            {
                Instantiate(GameObject.Find("Red Pin"), new Vector3(-2.97f, -0.75f, -0.3f), Quaternion.identity);
                passSelect.ResetTimer();
            }
        }
    }

    void E4State()
    {
        if (passSelect.timerMaximum <= passSelect.timerHitMaximum)
        {
            passSelect.E4();
            if (Input.GetKeyDown(KeyCode.D))
            {
                passSelect.E5();
                SetState(STATES.TileE5);
                passSelect.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.A))
            {
                passSelect.E3();
                SetState(STATES.TileE3);
                passSelect.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.W))
            {
                passSelect.D4();
                SetState(STATES.TileD4);
                passSelect.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.Return))
            {
                Instantiate(GameObject.Find("Red Pin"), new Vector3(-2.36f, -0.75f, -0.3f), Quaternion.identity);
                passSelect.ResetTimer();
            }
        }
    }

    void E5State()
    {
        if (passSelect.timerMaximum <= passSelect.timerHitMaximum)
        {
            passSelect.E5();
            if (Input.GetKeyDown(KeyCode.A))
            {
                passSelect.E4();
                SetState(STATES.TileE4);
                passSelect.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.W))
            {
                passSelect.D5();
                SetState(STATES.TileD5);
                passSelect.ResetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.Return))
            {
                Instantiate(GameObject.Find("Red Pin"), new Vector3(-1.76f, -0.75f, -0.3f), Quaternion.identity);
                passSelect.ResetTimer();
            }
        }
    }
}
