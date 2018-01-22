using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Name - Kaitlin Soter
 * 1/17/2018
 * Credit: Project & Portfolio 4 - Mega Man 2 group project
 * Purpose: holds transform positions for the SelectBoss Gameobject for where it moves
 */

public class BossSelection : MonoBehaviour {

    [SerializeField] Transform selectBoss;
    public static BossSelection instance;
    float timerMax = 0.2f;
    float timeHitMax;

    private void Awake()
    {
        instance = this;
    }
    // Use this for initialization
    void Start ()
    {
        selectBoss.GetComponent<Transform>();

        ResetTimer();

        Cursor.visible = false; // Sets the mouse cursor to invisible
	}

    void Update()
    {
        timeHitMax += Time.deltaTime;
    }

    public void ResetTimer()
    {
        timeHitMax = 0;
    }

    public void BubbleMan()
    {
        selectBoss.position = new Vector2(-4f, 4f);
    }

    public void AirMan()
    {
        selectBoss.position = new Vector2(0f, 4f);
    }

    public void QuickMan()
    {
        selectBoss.position = new Vector2(4f, 4f);
    }

    public void HeatMan()
    {
        selectBoss.position = new Vector2(-4f, 1f);
    }

    public void DrWily()
    {
        selectBoss.position = new Vector2(0f, 1f);
    }

    public void WoodMan()
    {
        selectBoss.position = new Vector2(4f, 1f);
    }

    public void MetalMan()
    {
        selectBoss.position = new Vector2(-4f, -2f);
    }

    public void FlashMan()
    {
        selectBoss.position = new Vector2(0f, -2f);
    }

    public void CrashMan()
    {
        selectBoss.position = new Vector2(4f, -2f);
    }

    public float timerMaximum
    {
        get
        {
            return timerMax;
        }
    }

    public float timerHitMaximum
    {
        get
        {
            return timeHitMax;
        }
    }
}
