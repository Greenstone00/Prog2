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
        if (Input.GetKeyDown(KeyCode.Escape))  //esc megnyom�s�ra v�ltozik a GameIsPaused �llapota true-ra �s el�j�n a PauseMenu
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
        Time.timeScale = 0f;  //pasue-n�l meg�l�tja az id�tt, 0 frame / sec
        GameIsPaused = true;
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;  // menu-be val� l�p�s ut�n ha �jra j�tszani akarunk nem maradjon pause-olva a game
        Debug.Log("Loading menu.");
        SceneManager.LoadScene("Menu");
    }

    public void ExitGame()
    {
        Debug.Log("Exiting game.");
        Application.Quit();

    }

}
