using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
{
    public float speed;
    public Transform turretTransform;
    private Transform targetTransform;
    private GameObject dodoTarget;
    public GameObject motionSensorObject;


    private void Start()
    {
        transform.position = new Vector3(turretTransform.position.x-0.75f, turretTransform.position.y+0.4f, turretTransform.position.z);
        dodoTarget = motionSensorObject.GetComponent<MotionSensor>().dodoTarget;
        targetTransform = dodoTarget.transform;
    }

    private void FixedUpdate()
    {
        transform.position = Vector2.MoveTowards(transform.position, targetTransform.position, speed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag != "Bullet")
        {
            GameObject.Destroy(gameObject);
        }
    }
}
