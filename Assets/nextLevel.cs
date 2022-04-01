using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class nextLevel : MonoBehaviour
{
    public Text levelend;
    public void showEnd()
    {
        levelend.text = "All 3 Item Collected Head To Dhoka (Door)";
    }
}
