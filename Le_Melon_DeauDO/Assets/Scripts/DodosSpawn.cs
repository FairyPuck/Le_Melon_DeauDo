using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DodosSpawn : MonoBehaviour
{
    public GameObject Dodos;

    void Start()
    {
        DodosSpawning(4);
    }
    IEnumerator DodosSpawning(int dodosNumber)
    {
        while(dodosNumber != 0)
        {
            GameObject Dodo = GameObject.Instantiate(Dodos);
            yield return new WaitForSeconds(1);
            dodosNumber--;
        }
    }
}
