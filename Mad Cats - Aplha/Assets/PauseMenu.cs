using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))  //esc megnyomására változik a GameIsPaused állapota true-ra és elõjön a PauseMenu
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

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;  
        GameIsPaused = false;
    }
    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;  //pasue-nál megálítja az idõtt, 0 frame / sec
        GameIsPaused = true;
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;  // menu-be való lépés után ha újra játszani akarunk nem maradjon pause-olva a game
        Debug.Log("Loading menu.");
        SceneManager.LoadScene("Menu");
    }

    public void ExitGame()
    {
        Debug.Log("Exiting game.");
        Application.Quit();

    }

}
