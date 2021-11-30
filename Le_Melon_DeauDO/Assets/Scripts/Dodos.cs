using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dodos : MonoBehaviour
{
    public float walkSpeed;
    public Rigidbody2D rb;

    private void Update()
    {
        walk();
    }
    void walk()
    {
        rb.velocity = new Vector2(walkSpeed * Time.fixedDeltaTime, rb.velocity.y);
    }
}
