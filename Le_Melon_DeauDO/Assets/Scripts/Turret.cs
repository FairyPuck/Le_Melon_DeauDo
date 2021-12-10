using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    public GameObject bulletObject, motionSensorObject, resourcesUI;
    private IEnumerator coroutine;
    public int bulletsNumber;
    public Animator firingTurret;

    void Start()
    {
        firingTurret = GetComponent<Animator>();
        resourcesUI.GetComponent<Resources>().MakeTurret();
        coroutine = TurretFiring(bulletsNumber);
        StartCoroutine(coroutine);
    }

    private void Update()
    {
    }

    IEnumerator TurretFiring(int bulletsNumber)
    {
        while(bulletsNumber != 0)
        {
            if (motionSensorObject.GetComponent<MotionSensor>().active)
            {
                firingTurret.SetBool("isFiring", true);
                GameObject Dodo = GameObject.Instantiate(bulletObject);
                Dodo.SetActive(true);
                yield return new WaitForSeconds(0.4f);

            }
            else
            {
                firingTurret.SetBool("isFiring", false);
                yield return new WaitForSeconds(0.1f);

            }
        }
    }
}
