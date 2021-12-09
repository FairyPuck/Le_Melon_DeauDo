using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    public GameObject bulletObject, motionSensorObject, resourcesUI;
    private IEnumerator coroutine;
    public int bulletsNumber;

    void Start()
    {
        resourcesUI.GetComponent<Resources>().MakeTurret();
        coroutine = DodosSpawning(bulletsNumber);
        StartCoroutine(coroutine);
    }

    private void Update()
    {
    }

    IEnumerator DodosSpawning(int bulletsNumber)
    {
        while (bulletsNumber != 0)
        {
            if (motionSensorObject.GetComponent<MotionSensor>().active)
            {
                GameObject Dodo = GameObject.Instantiate(bulletObject); 
                Dodo.SetActive(true);
                yield return new WaitForSeconds(1);
                bulletsNumber--;
            }
            else
            {
                yield return new WaitForSeconds(0.1f);
            }
        }
        
    }
}
