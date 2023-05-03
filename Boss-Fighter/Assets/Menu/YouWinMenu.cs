using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class YouWinMenu : MonoBehaviour
{
    [SerializeField] private Button againButton;
    [SerializeField] private Button quitButton;

    void Start()
    {
        againButton.onClick.AddListener(Again);
        quitButton.onClick.AddListener(Quit);
    }

    public void Again()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void Quit()
    {
        SceneManager.LoadScene("StartMenu");
    }
}
