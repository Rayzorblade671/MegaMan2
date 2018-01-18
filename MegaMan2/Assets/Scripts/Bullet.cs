using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*Name: Lyndon Jones
 *Date: 1/17/18
 *Credit: Project & Portfolio 4 - MegaMan 2 group project
 *Purpose: Sets damage, speed, and direction for bullet prefab                            */
public class Bullet : MonoBehaviour
{

    public Direction bulletDirection = Direction.RIGHT;
    public float speed = 5.0f;
    public int damage = 2;

    private Transform _transform;

    void Start() {
        _transform = transform;
    }

    // Update is called once per frame
    void Update() {
        MoveBullet();
  
    }

    // Causes the bullet to move at a set speed
    void MoveBullet() {
        int moveDirection = bulletDirection == Direction.LEFT ? -1 : 1;

        float translate = moveDirection * speed * Time.deltaTime;
        _transform.Translate(translate, 0, 0);

    }

    // Allows bullet to collide with Enemy tag
    void OnCollisionEnter2D(Collision2D collision){
        if (collision.collider.tag == "Enemy") {
            collision.collider.gameObject.GetComponent<EnemyData>().Damage(damage);
            Destroy(gameObject);
        }

    }
}


