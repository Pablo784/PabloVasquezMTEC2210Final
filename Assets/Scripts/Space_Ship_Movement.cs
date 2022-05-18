using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Space_Ship_Movement : MonoBehaviour
{

    public float speed = 4.0f;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float xMove = Input.GetAxisRaw("Horizontal");
        float yMove = Input.GetAxisRaw("Vertical");

        float xMovement = xMove * speed * Time.deltaTime;
        float yMovement = yMove * speed * Time.deltaTime;

        transform.Translate(xMovement, yMovement, 0);

        Debug.Log("Instructions: Left Click To Shoot");
    }
}
