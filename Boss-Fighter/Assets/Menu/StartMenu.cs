using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    [SerializeField] private Button startButton;
    [SerializeField] private Button quitButton;

    void Start()
    {
        startButton.onClick.AddListener(Join);
        quitButton.onClick.AddListener(Quit);
    }

    public void Join()
    {
        SceneManager.LoadScene("Game1");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
