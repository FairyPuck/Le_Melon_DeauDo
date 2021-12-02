using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MelonDeauDO : MonoBehaviour
{

    public float healthPoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DodoBite()
    {
        healthPoint -= 10;
        if(healthPoint <= 0)
        {
            MelonDie();
        }
    }

    private void MelonDie()
    {
        GameObject.Destroy(gameObject);
        SceneManager.LoadScene(2);

    }
}
