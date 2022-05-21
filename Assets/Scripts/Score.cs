using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{

    public static int scoreValue = 0;
    public TextMeshPro ScoreText;

    /* LINKS I USED
   * - https://youtu.be/M9yOOIVI2xM // YOUTUBE VIDEO #1

   * - https://youtu.be/0XUMCT17UUI // YOUTUBE VIDEO #2 (THIS ONE IS IN A FOREIGN LANGUAGE)
   * 
   * -  https://learn.unity.com/tutorial/lesson-5-2-keeping-score#5ce6151aedbc2a0076e74016
   * 
   * - https://youtu.be/QbqnDbexrCw // YOUTUBE VIDEO #3 (THIS IS THE ONE THAT REALLY HELPED)
   * 
   */

    // Start is called before the first frame update
    void Start()
    {
        ScoreText = GetComponent<TextMeshPro>();


    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = "Score: " + scoreValue;
        ScoreText.text = scoreValue.ToString();

    }
}
    

