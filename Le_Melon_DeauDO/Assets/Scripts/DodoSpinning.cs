using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DodoSpinning : MonoBehaviour
{
    public float speed = 1;
    public float RotAngleZ = 20;
    void Start()
    {
        
    }

        // Update is called once per frame
        void Update()
    {
        float rZ = Mathf.SmoothStep(0, RotAngleZ, Mathf.PingPong(Time.time * speed, 1));
        transform.rotation = Quaternion.Euler(0, 0, rZ);
    }
}
