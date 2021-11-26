using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rigidbody;
    public float Speed = 5f, Force = 300f;
    public bool playerJump = false, playerIsJumping = false, unplacedTurretActive = false;
    float axisX;
    public Vector3 playerPosition;

    public GameObject unplacedTurretObject;

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        if(playerJump)
        {
            playerJump = false;
            rigidbody.AddForce(Vector3.up * Force);
        }
    }

    private void Update()
    {
        playerPosition = transform.position;  
        transform.Translate(Vector2.right * Speed * axisX * Time.deltaTime);
    }

    public void OnJump()
    {
        if(!playerIsJumping)
        {
            playerJump = true;
        }
    }

    public void OnMove(InputValue val)
    {
        axisX = val.Get<float>();
    }

    public void OnPlaceTurret()
    {
        if (!unplacedTurretActive)
        {
            unplacedTurretObject.SetActive(true);
            unplacedTurretActive = true;
        }
        else
        {
            unplacedTurretObject.SetActive(false);
            unplacedTurretActive = false;
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Floor")
        {
            playerIsJumping = false;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            playerIsJumping = true;
        }
    }

}
