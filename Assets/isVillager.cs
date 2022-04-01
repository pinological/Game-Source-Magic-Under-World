using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isVillager : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player") { 
        FindObjectOfType<diaglo>().villageEnterDiaglo();
        }
        else
        {
            FindObjectOfType<diaglo>().VillageLeft();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            FindObjectOfType<diaglo>().VillageLeft();
        }
    }


}
