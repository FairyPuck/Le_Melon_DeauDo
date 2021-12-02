using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Button playButton;

    void Start()
    {
        Button retry = playButton.GetComponent<Button>();
        retry.onClick.AddListener(Play);
    }

    void Play()
    {
        SceneManager.LoadScene(1);
    }
}
