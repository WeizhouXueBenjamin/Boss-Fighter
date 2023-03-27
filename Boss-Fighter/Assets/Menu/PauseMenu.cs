using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private Button pauseButton;
    [SerializeField] private GameObject pausePanel;
    [SerializeField] private Button resumeButton;

    void Start()
    {
        pausePanel.SetActive(false);
        pauseButton.onClick.AddListener(Pause);
        resumeButton.onClick.AddListener(Resume);
    }

    private void Pause()
    {
        Time.timeScale = 0;
        pausePanel.SetActive(true);
        pauseButton.gameObject.SetActive(false);
    }

    private void Resume()
    {
        Time.timeScale = 1;
        pausePanel.SetActive(false);
        pauseButton.gameObject.SetActive(true);
    }
}