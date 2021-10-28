using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SexyHighScore : MonoBehaviour
{

    public int score;
    public List<int> highScore = new List<int>(5);
    public Text text;

    public Text highScore1;
    public Text highScore2;
    public Text highScore3;
    public Text highScore4;
    public Text highScore5;

    public void Start()
    {
        highScore[0] = 0;
        highScore[1] = 0;
        highScore[2] = 0;
        highScore[3] = 0;
        highScore[4] = 0;

        highScore[0] = PlayerPrefs.GetInt("hs1");
        highScore[1] = PlayerPrefs.GetInt("hs2");
        highScore[2] = PlayerPrefs.GetInt("hs3");
        highScore[3] = PlayerPrefs.GetInt("hs4");
        highScore[4] = PlayerPrefs.GetInt("hs5");
    }


    public void Update()
    {
        Debug.Log(highScore.Count);
        text.text = score + ".pts";
        highScore1.text = highScore[0] + ".pts";
        highScore2.text = highScore[1] + ".pts";
        highScore3.text = highScore[2] + ".pts";
        highScore4.text = highScore[3] + ".pts";
        highScore5.text = highScore[4] + ".pts";

    }
    public void Score()
        {
            score += 1;
        }
    public void OnDeath()
    {
        Debug.Log(highScore.Count);
        for (int i = 0; i < highScore.Count; i++)
        {
            if (highScore[i] < score)
            {
                highScore.Insert(i,score);
                highScore.RemoveAt(highScore.Count - 1);
                break;
            }
        }
        score = 0;
        PlayerPrefs.SetInt("hs1", highScore[0]);
        PlayerPrefs.SetInt("hs2", highScore[1]);
        PlayerPrefs.SetInt("hs3", highScore[2]);
        PlayerPrefs.SetInt("hs4", highScore[3]);
        PlayerPrefs.SetInt("hs5", highScore[4]);

    }

}
