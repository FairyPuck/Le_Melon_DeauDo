using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DodosSpawn : MonoBehaviour
{
    public GameObject Dodos;
    public int dodosNumber;
    private IEnumerator coroutine;

    void Start()
    {
        coroutine = DodosSpawning(dodosNumber);
        StartCoroutine(coroutine);
    }
    IEnumerator DodosSpawning(int dodosNumber)
    {
        while (dodosNumber != 0)
        {
            GameObject Dodo = GameObject.Instantiate(Dodos);
            Dodo.SetActive(true);
            yield return new WaitForSeconds(0.5f);
            dodosNumber--;
        }
    }
}
