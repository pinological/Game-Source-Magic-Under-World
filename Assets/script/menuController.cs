using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;

public class menuController : MonoBehaviour
{
    public AudioMixer audiomixer;
    public Text warningText;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.None;
    }
    public void newGame()
    {
        SceneManager.LoadScene(1);
    }

    public void setQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }
    public void SetVolume(float volume)
    {
        audiomixer.SetFloat("volume", volume);
    }
    
    public void setDiffculty(int deffIndex)
    {
        FindObjectOfType<playerStat>().sethealth(deffIndex);
    }

    public void LoadOld()
    {
        if (FindObjectOfType<GameSave>().check())
        {
            int seanIndex = FindObjectOfType<GameSave>().getLevel();
            SceneManager.LoadScene(seanIndex);
        }
        else
        {
            warningText.text = "No Old Data Click New Game";
        }
    }

    public void quitgame()
    {
        Application.Quit();
    }


}
