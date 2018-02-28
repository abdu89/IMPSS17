using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreNum : MonoBehaviour {

    public static int score;

    public Text scoreNum;
    public Text highScoreNum;

	void Start () {

        scoreNum = scoreNum.GetComponent<Text>();
        highScoreNum = highScoreNum.GetComponent<Text>();
        scoreNum.text = PlayerPrefs.GetInt("Score",0).ToString();
        highScoreNum.text = PlayerPrefs.GetInt("Highscore",0).ToString();


	}
	
	void Update () {

        scoreNum.text = score.ToString();
        PlayerPrefs.SetInt("Score",score);
        if (score > PlayerPrefs.GetInt("Highscore",0))
        {
            PlayerPrefs.SetInt("Highscore", score);
            highScoreNum.text = score.ToString();
        }

	}
    public void HighScoreReset()
    {
        PlayerPrefs.DeleteKey("Highscore");
        highScoreNum.text = "0";
    }
    public void ScoreReset()
    {
        PlayerPrefs.DeleteKey("Score");
        scoreNum.text = "0";
    }
}
