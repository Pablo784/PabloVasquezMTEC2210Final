using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{

    public Transform firePoint;
    public GameObject bulletPrefab;

    public float bulletForce = 20f;


    /*
    THIS YOUTUBE VIDEO HELPED ME A LOT 
    https://youtu.be/LNLVOjbrQj4
     
    */

    // Update is called once per frame
    void Update()
    {
    
        if (Input.GetButtonDown("Fire1"))
        {
            
            Shoot();

            Score.scoreValue += 2; // THIS LINE OF CODE GIVES THE PLAYER THEIR SCORE

        }

        void Shoot()
        {
          
            GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();

            rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
           


        }

        Debug.Log("KILL THE ENEMY WITH THE LEFT CLICK OF YOUR MOUSE!");
    }

}
