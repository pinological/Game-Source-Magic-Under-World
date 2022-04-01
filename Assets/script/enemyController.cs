using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class enemyController : MonoBehaviour
{
    public NavMeshAgent enemy;
    public Transform player;
    public Animator enemyAni;
    float health = 0;
    public playerStat PlayerStat;
    int enemyHealth = 10;
    public GameObject EnemyBody;

    private void Start()
    {
        health = PlayerStat.gethealth();
    }
    

    public void idel()
    {

        enemyAni.SetBool("isNear", false);

    }

    public void attack()
    {
        if(health >= 0) { 
        health -= 100;
        FindObjectOfType<healthBar>().SetHealth((int)(health));
        PlayerStat.sethealth(health);
        Debug.Log(health);
        }
        else
        {
            Debug.Log("Player Dead");
        }
    }

    public void chasePlayer()
    {
        Debug.Log("Player");
        enemyAni.SetBool("isNear", true);
        enemy.SetDestination(player.position);
        FindObjectOfType<EnemyAudio>().playEnemyAudio();
        //FindObjectOfType<diaglo>().EnemyHealth();
    }

    public void getEnemyhit()
    {
        enemyHealth--;
        if(enemyHealth <= 0)
        {
            Destroy(EnemyBody);
        }
        
    }
    public int getEnemyHealth()
    {
        return enemyHealth;
    }

}
