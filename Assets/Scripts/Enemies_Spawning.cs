using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies_Spawning : MonoBehaviour
{

    /*
     THIS YOUTBE VIDEO HELPED ME A LOT
    - https://youtu.be/AI8XNNRpTTw
     */

    public GameObject enemy;
    float randX;
    Vector2 wheretoSpawn;
    public float spawnRate = 0f;
    float nextSpawn = 0.0f;

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        if (Time.time > nextSpawn)
            

        {
          
            nextSpawn = Time.time + spawnRate;
            randX = Random.Range(-8.4f, 8.4f);
            wheretoSpawn = new Vector2(randX, transform.position.y);
            Instantiate(enemy, wheretoSpawn, Quaternion.identity);
            
        }


    }
}


