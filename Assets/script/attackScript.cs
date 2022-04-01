using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attackScript : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            attackPlayer();
        }
    }

    void attackPlayer()
    {
        FindObjectOfType<enemyController>().attack();
    }
}
