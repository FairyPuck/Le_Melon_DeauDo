using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dodos : MonoBehaviour
{
    public float walkSpeed;
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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Melon")
        {
            melonObject.GetComponent<MelonDeauDO>().DodoBite();
            GameObject.Destroy(this.gameObject);
        }
    }
}
