using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public Button startGameButton;
    public Button endButton;


    void Start()
    {
        startGameButton.onClick.AddListener(GameScene);
        endButton.onClick.AddListener(EndGame);
    }

    public void GameScene()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void EndGame()
    {
        Application.Quit();
    }
}
