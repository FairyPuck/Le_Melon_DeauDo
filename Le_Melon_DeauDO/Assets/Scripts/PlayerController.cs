using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rigidBody;
    public float Speed = 5f, Force = 300f;
    public bool playerJump = false, playerIsJumping = false;
    float axisXGet, axisXSet;
    public Vector3 playerPosition;
    public Quaternion rotate;

    public bool unplacedTurretActive = false;
    public GameObject unplacedTurretObject, turretObject, resourcesUI;


    //public GameObject popupBox;
    //public Animator animator;
    //public TMP_Text popupText;

    private void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        if(playerJump)
        {
            playerJump = false;
            rigidBody.AddForce(Vector3.up * Force);
        }
    }

    private void Update()
    {
        playerPosition = transform.position;  
        transform.Translate(Vector2.right * Speed * axisXSet * Time.deltaTime);
    }

    //public void PopUp(string text)
    //{
    //    popupBox.SetActive(true);
    //    popupText.text = text;
    //    //animator.SetTrigger("pop");
    //}

    public void OnJump()
    {
        if(!playerIsJumping)
        {
            playerJump = true;
        }
    }

    public void OnMove(InputValue val)
    {
        axisXGet = val.Get<float>();
        if(axisXGet == 1)
        {
            rotate = Quaternion.Euler(0, 180, 0);
            transform.rotation = rotate;
            axisXSet = -1;
        }
        else if(axisXGet == -1)
        {
            rotate = Quaternion.Euler(0, 0, 0);
            transform.rotation = rotate;
            axisXSet = -1;
        }
        else axisXSet = 0;
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
            
            if (
                unplacedTurretObject.GetComponent<UnplacedTurret>().canPlaceTheTurret 
                && !playerIsJumping 
                && resourcesUI.GetComponent<Resources>().metal >= 50 
                && resourcesUI.GetComponent<Resources>().melonJuice >= 50
                )
            {
                GameObject newTurret = GameObject.Instantiate(turretObject);
                newTurret.transform.position = unplacedTurretObject.transform.position;
                newTurret.SetActive(true);
                unplacedTurretObject.SetActive(false);
                unplacedTurretActive = false;
            }
            else
            {
                //PopUp("You cannot place the turret here !");
            }
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Floor")
        {
            unplacedTurretObject.GetComponent<UnplacedTurret>().canPlaceTheTurret = true;
            playerIsJumping = false;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            unplacedTurretObject.GetComponent<UnplacedTurret>().canPlaceTheTurret = false;
            playerIsJumping = true;
        }
    }

}
