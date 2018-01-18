using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum Direction {LEFT, RIGHT}
public class PlayerController : MonoBehaviour {

    public float speed = 5.0f;
    public bool isGrounded = false;
    public float jumpPower = 7.0f;
    public int health = 28;
  

    private Transform _transform;
    private Rigidbody2D _rigidbody;
    private Direction playerDirection = Direction.RIGHT;

    public Direction PlayerDirection { 
     get {
        return playerDirection;
    }
}

	// Use this for initialization
	void Start ()
    {
        _transform = GetComponent(typeof(Transform)) as Transform;
        _rigidbody = GetComponent(typeof(Rigidbody2D)) as Rigidbody2D;
        print(health);
	}
	
	// Update is called once per frame
	void Update ()
    {
        MovePlayer();
        Jump();

        if(health <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
	}

    //Self-explainatory 
    void MovePlayer()
    {
        float translate = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        transform.Translate(translate, 0, 0);

        if (translate > 0)
        {
            playerDirection = Direction.RIGHT;
        } else if (translate < 0)
        {
            playerDirection = Direction.LEFT;
        }
    }

    void Jump()
    {
        if(Input.GetKeyDown(KeyCode.J) && isGrounded)
        {
            _rigidbody.AddForce(new Vector2(0, jumpPower), ForceMode2D.Impulse);
        }
    }


}
