using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenuScript : MonoBehaviour
{
    [SerializeField] private Button pauseButton;
    [SerializeField] private GameObject pausePanel;
    [SerializeField] private Button resumeButton;
    [SerializeField] private Button quitButton;

    void Start()
    {
        pausePanel.SetActive(false);
        pauseButton.onClick.AddListener(Pause);
        resumeButton.onClick.AddListener(Resume);
        quitButton.onClick.AddListener(Quit);
    }

    private void Pause()
    {
        Time.timeScale = 0;  // 時間停止
        pausePanel.SetActive(true);
        pauseButton.gameObject.SetActive(false);
    }

    private void Resume()
    {
        Time.timeScale = 1;  // 再開
        pausePanel.SetActive(false);
        pauseButton.gameObject.SetActive(true);
    }

    private void Quit()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
