using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PasswordSelection : MonoBehaviour {

    [SerializeField] Transform selectTile;
    //bandaid so that it doesn't call 2 functions within the same frame
    float timerMax = 0.2f;
    float timerHitMax;

	// Use this for initialization
	void Start () {
        selectTile.GetComponent<Transform>();
        ResetTimer();
    }
	
	// Update is called once per frame
	void Update () {
        timerHitMax += Time.deltaTime;
    }

    public void ResetTimer()
    {
        timerHitMax = 0;
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
            return timerHitMax;
        }
    }

    public void A1()
    {
        selectTile.position = new Vector3(-4.17f, 1.73f, -0.3f);
    }

    public void A2()
    {
        selectTile.position = new Vector3(-3.56f, 1.73f, -0.3f);
    }

    public void A3()
    {
        selectTile.position = new Vector3(-2.97f, 1.73f, -0.3f);
    }

    public void A4()
    {
        selectTile.position = new Vector3(-2.36f, 1.73f, -0.3f);
    }

    public void A5()
    {
        selectTile.position = new Vector3(-1.76f, 1.73f, -0.3f);
    }

    public void B1()
    {
        selectTile.position = new Vector3(-4.17f, 1.12f, -0.3f);
    }

    public void B2()
    {
        selectTile.position = new Vector3(-3.56f, 1.12f, -0.3f);
    }

    public void B3()
    {
        selectTile.position = new Vector3(-2.97f, 1.12f, -0.3f);
    }

    public void B4()
    {
        selectTile.position = new Vector3(-2.36f, 1.12f, -0.3f);
    }

    public void B5()
    {
        selectTile.position = new Vector3(-1.76f, 1.12f, -0.3f);
    }

    public void C1()
    {
        selectTile.position = new Vector3(-4.17f, 0.5f, -0.3f);
    }

    public void C2()
    {
        selectTile.position = new Vector3(-3.56f, 0.5f, -0.3f);
    }

    public void C3()
    {
        selectTile.position = new Vector3(-2.97f, 0.5f, -0.3f);
    }

    public void C4()
    {
        selectTile.position = new Vector3(-2.36f, 0.5f, -0.3f);
    }

    public void C5()
    {
        selectTile.position = new Vector3(-1.76f, 0.5f, -0.3f);
    }

    public void D1()
    {
        selectTile.position = new Vector3(-4.17f, -0.13f, -0.3f);
    }

    public void D2()
    {
        selectTile.position = new Vector3(-3.56f, -0.13f, -0.3f);
    }

    public void D3()
    {
        selectTile.position = new Vector3(-2.97f, -0.13f, -0.3f);
    }

    public void D4()
    {
        selectTile.position = new Vector3(-2.36f, -0.13f, -0.3f);
    }

    public void D5()
    {
        selectTile.position = new Vector3(-1.76f, -0.13f, -0.3f);
    }

    public void E1()
    {
        selectTile.position = new Vector3(-4.17f, -0.75f, -0.3f);
    }

    public void E2()
    {
        selectTile.position = new Vector3(-3.56f, -0.75f, -0.3f);
    }

    public void E3()
    {
        selectTile.position = new Vector3(-2.97f, -0.75f, -0.3f);
    }

    public void E4()
    {
        selectTile.position = new Vector3(-2.36f, -0.75f, -0.3f);
    }

    public void E5()
    {
        selectTile.position = new Vector3(-1.76f, -0.75f, -0.3f);
    }
}
