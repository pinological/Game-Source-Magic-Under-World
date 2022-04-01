using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseMenu : MonoBehaviour
{
    public static bool GameIspause = false;
    public GameObject pauseMenuUI;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.None;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //SceneManager.LoadScene("Pause");
            if (GameIspause)
            {
                Resume();
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
            }
            else
            {
                Pausegame();
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }

        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if(Input.GetKeyDown(KeyCode.L))
        {
            saveGame();
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            SceneManager.LoadScene(1);
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Application.Quit();
        }
    }
    void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIspause = false;
        

    }
    void Pausegame()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIspause = true;
        

    }
    public void saveGame()
    {
        Debug.Log(SceneManager.GetActiveScene().buildIndex);
        FindObjectOfType<GameSave>().save(SceneManager.GetActiveScene().buildIndex);
    }


}
