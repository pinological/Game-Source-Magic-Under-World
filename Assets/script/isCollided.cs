using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isCollided : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            FindObjectOfType<playerStat>().collect();
            Destroy(gameObject);
            FindObjectOfType<collectAudio>().playCollectAudio();
        }
    }
}
