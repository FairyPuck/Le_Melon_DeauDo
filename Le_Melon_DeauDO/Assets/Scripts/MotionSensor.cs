using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotionSensor : MonoBehaviour
{
    public bool active = false;
    public GameObject dodoTarget;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Dodo")
        {
            active = true;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Dodo")
        {
            dodoTarget = collision.gameObject;
            active = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Dodo")
        {
            active = false;
        }
    }
}
