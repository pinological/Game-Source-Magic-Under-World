using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class diaglo : MonoBehaviour
{
    public Text dialogtext;

    public void villageEnterDiaglo()
    {
        dialogtext.text = "Nice Night, Dont Mind Me , I am just feeling the air. Any Way you came from that cave right. If you wanna goto next world collect 3 tirsul and head to that door";
    }

    public void VillageLeft()
    {
        dialogtext.text = "";
    }

    public void EnemyHealth()
    {
        dialogtext.text = "Enemy Health : " + FindObjectOfType<enemyController>().getEnemyHealth();
    }

    public void playerDead()
    {
        dialogtext.text = "You Died Press R to Restart";
        Time.timeScale = 0f;
    }

    

}
