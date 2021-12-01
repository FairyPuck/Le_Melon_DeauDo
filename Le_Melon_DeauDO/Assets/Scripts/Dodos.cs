using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dodos : MonoBehaviour
{
    public float walkSpeed, healthPoint;
    public Rigidbody2D rb;
    public GameObject melonObject;

    private void Update()
    {
        walk();
    }
    void walk()
    {
        rb.velocity = new Vector2(walkSpeed * Time.fixedDeltaTime, rb.velocity.y);
    }

    private void hurt()
    {
        healthPoint -= 33;
        if(healthPoint <= 0)
        {
            die();
        }
    }

    private void die()
    {
        GameObject.Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Melon")
        {
            melonObject.GetComponent<MelonDeauDO>().DodoBite();
            GameObject.Destroy(this.gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Bullet")
        {
            hurt();
        }
    }
}
