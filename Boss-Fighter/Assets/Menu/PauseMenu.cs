using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject pausePanel;
    [SerializeField] private Button resumeButton;
    [SerializeField] private Button quitButton;
    bool is_paused = false;

    void Start()
    {
        pausePanel.SetActive(false);
        resumeButton.onClick.AddListener(Resume);
        quitButton.onClick.AddListener(Back);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(!is_paused)
            {
                Pause();
            }  
            else
            {
                Resume();
            }
        }
    }

    private void Pause()
    {
        Time.timeScale = 0;
        is_paused = true;
        pausePanel.SetActive(true);
    }

    private void Resume()
    {
        Time.timeScale = 1;
        is_paused = false;
        pausePanel.SetActive(false);
    }

    private void Back()
    {
        Time.timeScale = 1;
        is_paused = false;
        SceneManager.LoadScene("StartMenu");
    }
}
