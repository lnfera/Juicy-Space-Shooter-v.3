using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreSystem : MonoBehaviour
{
    public int score;

    public int highScore1 = 100;
    public int highScore2 = 20;
    public int highScore3 = 10;
    public int highScore4 = 5;
    public int highScore5 = 0;

    public Text text;

    public void OnDeath()
    {
        text.enabled = true;
        text.text = "You scored " + score + ".pts!"; 

        if (score >= highScore1) 
        {   
            highScore5 = highScore4;
            highScore4 = highScore3;
            highScore3 = highScore2;
            highScore2 = highScore1;
            score = 0;

        }
        if (score >= highScore2)
        {
            highScore5 = highScore4;
            highScore4 = highScore3;
            highScore3 = highScore2;
            highScore2 = score;
            score = 0;
        }
        if (score >= highScore3)
        {
            highScore5 = highScore4;
            highScore4 = highScore3;
            highScore3 =  score;
            score = 0;
        }
        if (score >= highScore3)
        {
            highScore5 = highScore4;
            highScore4 = highScore3;
            highScore3 = score;
            score = 0;
        }
        if (score >= highScore4)
        {
            highScore5 = highScore4;
            highScore4 = score;
            score = 0;
        }
        if (score >= highScore5)
        {
            highScore5 = score;
            score = 0;
        }
        else 
        {

            score = 0;
        }

    }
}

