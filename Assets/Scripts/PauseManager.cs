using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour
{

    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public GameObject pauseMenuUI2;

    public GameObject visualPanel;
    public GameObject audioPanel;
    public GameObject controlsPanel;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    public void Settings()
    {
        pauseMenuUI.SetActive(false);
        pauseMenuUI2.SetActive(true);
    }
    public void Back()
    {
        pauseMenuUI.SetActive(true);
        pauseMenuUI2.SetActive(false);
    }
    public void Visual()
    {
        visualPanel.SetActive(true);
        audioPanel.SetActive(false);
        controlsPanel.SetActive(false);
    }
    public void Audio()
    {
        visualPanel.SetActive(false);
        audioPanel.SetActive(true);
        controlsPanel.SetActive(false);
    }
    public void Controls()
    {
        visualPanel.SetActive(false);
        audioPanel.SetActive(false);
        controlsPanel.SetActive(true);
    }
    public void Player()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Player Select");
    }
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1;
        GameIsPaused = false;
    }
    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0;
        GameIsPaused = true;
    }
    public void LoadMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Main Menu");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
