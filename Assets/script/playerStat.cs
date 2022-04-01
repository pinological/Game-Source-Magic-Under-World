using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerStat : MonoBehaviour
{
    public float health = 1000f;

    public int collectable = 0;
    public Transform playerLoaction;

    public void setPlayerHealth(int index)
    {
        if(index == 0)
        {
            health = 1000f;
        }
        else if(index == 1)
        {
            health = 100f;
        }
        else
        {
            health = 10000f;
        }
    }

    public void sethealth(float num)
    {
        health = num;
        if(health <= 0)
        {
            Debug.Log("Player Ded");
            FindObjectOfType<diaglo>().playerDead();
        }
    }
    public float gethealth()
    {
        return health;
    }

    public void collect()
    {
        
        collectable++;
        Debug.Log("Item Collected : " + collectable);
        if (collectable >= 3)
        {
            Debug.Log("Complete 3 Key");
            FindObjectOfType<lighControl>().changeColor();
            FindObjectOfType<collectAudio>().playComplete();
            FindObjectOfType<nextLevel>().showEnd();
            FindObjectOfType<nextLevelDhoka>().isLevelComplete = true;
        }
    }




}
