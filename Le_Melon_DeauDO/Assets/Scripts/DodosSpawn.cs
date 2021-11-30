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
        Debug.Log("iygf");
        while (dodosNumber != 0)
        {
            Debug.Log("start");
            GameObject Dodo = GameObject.Instantiate(Dodos);
            Dodo.SetActive(true);
            yield return new WaitForSeconds(2);
            dodosNumber--;
        }
    }
}
