using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DodosSpawn : MonoBehaviour
{
    public GameObject Dodos;
    private IEnumerator wavesCouroutine, spawningCouroutine;
    private List<int> dodosNumberPerWave = new List<int>();
    public int[] dodosNumberPerWaveArray = { 3, 8, 15, 30, 60, 70, 90 };


    void Start()
    {
        AddToList(dodosNumberPerWaveArray);
        wavesCouroutine = DodosWaves(dodosNumberPerWave.Count, dodosNumberPerWave);
        StartCoroutine(wavesCouroutine);
    }

    void AddToList(int[] list)
    {
        for (int i = 0; i < list.Length; i++)
        {
            dodosNumberPerWave.Add(list[i]);
        }
    }

    IEnumerator DodosWaves(int wavesNumber, List<int> dodosNumberPerWave)
    {
        while (wavesNumber != 0)
        {
            spawningCouroutine = DodosSpawning(dodosNumberPerWave[0]);
            StartCoroutine(spawningCouroutine);
            dodosNumberPerWave.RemoveAt(0);
            yield return new WaitForSeconds(15);
        }
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
