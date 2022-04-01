using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class magicballScript : MonoBehaviour
{
    private bool collided;
    public GameObject explosion;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag != "Bullet" && collision.gameObject.tag != "Player" && !collided)
        {
            collided = true;
            var impact = Instantiate(explosion, collision.contacts[0].point, Quaternion.identity) as GameObject;
            Destroy(impact, 2f);

            if(collision.gameObject.tag == "box")
            {
                Destroy(collision.gameObject);
            }
            if(collision.gameObject.tag == "enemy")
            {
                FindObjectOfType<enemyController>().getEnemyhit();
            }

            Destroy(gameObject);
            Debug.Log(collision.gameObject.tag);
            
        }

    }
}
