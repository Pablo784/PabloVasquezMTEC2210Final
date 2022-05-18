using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class GameManager : MonoBehaviour
{

    private float timeRemaining;
    public float spawnDelay;

    public TextMeshPro timerText;
    private Timer timer;

    // Start is called before the first frame update
    void Start()
    {
        timer = GetComponent<Timer>();
        timeRemaining = spawnDelay;
    }

    // Update is called once per frame
    void Update()
    {
        // This is the game time display
        if (timer.timerIsRunning)
        {
            timerText.text = timer.GetTimeForDisplay();
        }

        if (timeRemaining > 0f)
        {
            timeRemaining -= 1f * Time.deltaTime;
        }
        else
        {
            timeRemaining = spawnDelay;
        }
    }

}