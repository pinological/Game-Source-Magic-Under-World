using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class GameSave : MonoBehaviour
{
    // S
    public bool check()
    {
        return File.Exists(Application.dataPath + "/gamesave.txt");

    }

    public void save(int level)
    {
        File.WriteAllText(Application.dataPath + "/gamesave.txt", "" + level);

    }

    public int getLevel()
    {
        return int.Parse(File.ReadAllText(Application.dataPath + "/gamesave.txt"));
    }
}
