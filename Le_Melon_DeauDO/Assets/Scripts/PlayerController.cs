using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rigidbody;
    public float Speed = 5f, Force = 300f;
    public bool playerJump = false;
    float axisX;

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
        transform.Translate(Vector2.right * Speed * axisX * Time.deltaTime);
    }

    public void OnJump()
    {
        playerJump = true;
    }

    public void OnMove(InputValue val)
    {
        axisX = val.Get<float>();
        Debug.Log(axisX);
    }
}
