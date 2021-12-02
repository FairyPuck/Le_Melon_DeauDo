using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    public Transform turretTransform;

    private void Start()
    {
        transform.position = new Vector3(turretTransform.position.x, turretTransform.position.y-0.5f, turretTransform.position.z);
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(speed * Time.fixedDeltaTime, rb.velocity.y);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag != "Bullet")
        {
            GameObject.Destroy(gameObject);
        }
    }
}
