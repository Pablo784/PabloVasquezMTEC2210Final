using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


/* THESE ARE THE YOUTUBE VIDEO I HAVE USED 
    * - https://youtu.be/M9yOOIVI2xM // THIS VIDEO HELPED ME THE MOST 
    
    * - https://youtu.be/0XUMCT17UUI // THIS ONE IS IN A FOREIGN LANGUAGE
    *
    */

public class Score : MonoBehaviour
{
    public TMP_Text scoreText;
    public float scoreAmount;
    public float pointIncreasedPerSecond;
    

    // Start is called before the first frame update
    void Start()
    {
        scoreAmount = 0f;
        pointIncreasedPerSecond = 1f;
    }

    // Update is called once per frame
    void Update()
    {

        scoreText.text = "Score :" + (int)scoreAmount; 
        scoreAmount += pointIncreasedPerSecond * Time.deltaTime;
    }
}
