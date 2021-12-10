using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Watermelon_Move : MonoBehaviour
{

    public float speed = 30f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-speed * Time.deltaTime, 0, 0);
    }
}
