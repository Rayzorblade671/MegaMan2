using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/*Name: Lyndon Jones
 *Date: 1/17/18
 *Credit: Project & Portfolio 4 - MegaMan 2 group project
 *Purpose: Basic player movements, health, and damage taking                               */
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

    void OnCollisionEnter2D(Collision2D _collision)
    {
        isGrounded = true;
        if (_collision.gameObject.tag=="Enemy")
        {

            _collision.gameObject.GetComponent<EnemyData>();
            EnemyData enemyData = _collision.gameObject.GetComponent<EnemyData>();
            health -= enemyData.PhysicalDamage;
        }

        if (_collision.gameObject.tag == "Killzone")
        {
            health = 0;
        }
    }

    void OnCollisionExit2D()
    {
        isGrounded = false;
    } 
}
