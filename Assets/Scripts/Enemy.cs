using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
 THIS YOUTUBE VIDEO HELPED ME A LOT
- https://youtu.be/anHxFtiVuiE
 */



public class Enemy : MonoBehaviour
{
    [SerializeField] float health, maxHealth = 3f;
    

    private void Start()
    {
        
        health = maxHealth;
       
    }

    public void TakeDamage(float damageAmount)
    {
       
        health -= damageAmount;



        if (health <= 0)
            Destroy(gameObject);
        

    }

}

