using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lighControl : MonoBehaviour
{
    public Light doorlight;
    private void Start()
    {
        doorlight.color = Color.red;
    }
    public void changeColor()
    {
        doorlight.color = Color.green;
    }
}
