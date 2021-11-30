using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnplacedTurret : MonoBehaviour
{
    public bool canPlaceTheTurret = true;
    public GameObject playerObject;

    private void Update()
    {
        if (canPlaceTheTurret && !playerObject.GetComponent<PlayerController>().playerIsJumping)
        {
            GetComponent<Renderer>().material.SetColor("_Color", Color.white);
        }
        else
        {
            GetComponent<Renderer>().material.SetColor("_Color", Color.red);

        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "turret")
        {
            canPlaceTheTurret = false;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {   
        if (collision.tag == "turret")
        {
            canPlaceTheTurret = true;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "turret")
        {
            canPlaceTheTurret = false;
        }
    }

}
