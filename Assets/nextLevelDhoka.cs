using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextLevelDhoka : MonoBehaviour
{
    public bool isLevelComplete = false;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player" && isLevelComplete)
        {
            loadNextLevel();
        }
        else
        {
            Debug.Log("Only Player I guess");
        }
    }
    void loadNextLevel()
    {
        int current = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(current+1);
    }
}
