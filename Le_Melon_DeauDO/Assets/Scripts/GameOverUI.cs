using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverUI : MonoBehaviour
{
    public Button retryButton;
    public Button exitButton;

    // Start is called before the first frame update
    void Start()
    {
        Button retry = retryButton.GetComponent<Button>();
        retry.onClick.AddListener(Retry);

        Button exit = exitButton.GetComponent<Button>();
        exit.onClick.AddListener(Exit);
    }

    void Retry()
    {
        SceneManager.LoadScene(1);
    }

    void Exit()
    {
        SceneManager.LoadScene(0);
    }

    public void OnMouseOverRetry()
    {
        retryButton.image.color = new Color(250, 0, 0, 0.39f);
    }

    public void OnMouseExitRetry()
    {
        retryButton.image.color = new Color(250, 0, 0, 0);
    }

    public void OnMouseOverExit()
    {
        exitButton.image.color = new Color(250, 0, 0, 0.39f);
    }

    public void OnMouseExitExit()
    {
        exitButton.image.color = new Color(250, 0, 0, 0);
    }

}
