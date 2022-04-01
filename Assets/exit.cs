using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("exitgame", 5f);
        Cursor.lockState = CursorLockMode.None;
    }

    void exitgame()
    {
        Application.Quit();
    }
    
}
