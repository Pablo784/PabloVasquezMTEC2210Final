using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Timer : MonoBehaviour
{
    // I FOLLOWED THE RECORDING PROVIDED BY THE PROFESSOR VIA SLACK ON HOW TO SET UP A TIMER

    public float gameDurationInSeconds = 300;
    private float timeRemaining;
    public bool timerIsRunning = false;

    private void Start()
    {
        timeRemaining = gameDurationInSeconds;
        // Starts the timer automatically
        timerIsRunning = true;
    }


    /* Start is called before the first frame update
    void Start()
    {
        
    }
    */


    // Update is called once per frame
    void Update()
    {

        if (timerIsRunning)
        {
            if (timeRemaining > 1)
            {
                timeRemaining -= Time.deltaTime;
            }
            else
            {

            }
        }
        Debug.Log("Time has run out!");
        timeRemaining = 0;
        timerIsRunning = false;
    }





    public string GetTimeForDisplay()
    {
        float minutes = Mathf.FloorToInt(timeRemaining / 60);
        float seconds = Mathf.FloorToInt(timeRemaining % 60);
        return string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}