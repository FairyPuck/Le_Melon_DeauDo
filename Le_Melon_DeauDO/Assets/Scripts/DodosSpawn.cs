using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DodosSpawn : MonoBehaviour
{
    public GameObject Dodos;
    private IEnumerator coroutine;

    void Start()
    {
       coroutine = DodosSpawning(4);
        StartCoroutine(coroutine);
    }
    IEnumerator DodosSpawning(int dodosNumber)
    {
        while (dodosNumber != 0)
        {
            GameObject Dodo = GameObject.Instantiate(Dodos);
            Dodo.SetActive(true);
            yield return new WaitForSeconds(2);
            dodosNumber--;
        }
    }
}
