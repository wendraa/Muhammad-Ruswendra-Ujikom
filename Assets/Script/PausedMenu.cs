using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PausedMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public Button mainMenuButton;
    public Button resumeButton;

    private void Start()
    {
        mainMenuButton.onClick.AddListener(MainMenu);
        resumeButton.onClick.AddListener(Resume);
        if (Input.GetKeyDown("esc"))
        {
            Pause();
        }
    }
    void OnPausePressed()
    {
        if (GameIsPaused)
        {
            Resume();

        }
        // else
        // {
        //     StartCoroutine(Pause());
        // }

    }

    void Resume()
    {
        Time.timeScale = 1f;
        GameIsPaused = false;
        pauseMenuUI.SetActive(false);
    }

     void Pause()
     {
         pauseMenuUI.SetActive(true);
         GameIsPaused = true;
         Time.timeScale = 0f;
         Debug.Log("Escape");

     }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
