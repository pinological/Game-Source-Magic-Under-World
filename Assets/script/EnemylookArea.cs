using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemylookArea : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player") { 
        FindObjectOfType<enemyController>().chasePlayer();
        }
        else
        {
            FindObjectOfType<enemyController>().idel();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            FindObjectOfType<enemyController>().idel();
        }
    }

}
