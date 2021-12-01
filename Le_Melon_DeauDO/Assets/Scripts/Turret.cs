using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    public GameObject bulletObject;
    private IEnumerator coroutine;

    void Start()
    {
        coroutine = DodosSpawning(100);
        StartCoroutine(coroutine);
    }

    IEnumerator DodosSpawning(int bulletsNumber)
    {
        while (bulletsNumber != 0)
        {
            GameObject Dodo = GameObject.Instantiate(bulletObject);
            Dodo.SetActive(true);
            yield return new WaitForSeconds(1);
            bulletsNumber--;
        }
    }
}
