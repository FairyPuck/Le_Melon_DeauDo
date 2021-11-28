using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnplacedTurret : MonoBehaviour
{
    public bool canPlaceTheTurret = true;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "turret")
        {
            GetComponent<Renderer>().material.SetColor("_Color", Color.red);
            canPlaceTheTurret = false;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {   
        if (collision.tag == "turret")
        {
            GetComponent<Renderer>().material.SetColor("_Color", Color.white);
            canPlaceTheTurret = true;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "turret")
        {
            GetComponent<Renderer>().material.SetColor("_Color", Color.red);
            canPlaceTheTurret = false;
        }
    }


}
