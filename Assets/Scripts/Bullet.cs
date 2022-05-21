using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour


/*
THESE YOUTUBE VIDEOS HELPED ME A LOT:
- https://youtu.be/LNLVOjbrQj4
- https://youtu.be/anHxFtiVuiE
*/





{
    public GameObject hitEffect;


    private void OnCollisionEnter2D(Collision2D collision)
    {
       

        /*
        CODE FROM THE FIRST YOUTUBE VIDEO

        GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
        Destroy(effect, 5f);
        */


        Destroy(gameObject);
       if (collision.gameObject.TryGetComponent<Enemy>(out Enemy enemyComponent));

        


        {

            enemyComponent.TakeDamage(3);
           
        }
        
    }
}