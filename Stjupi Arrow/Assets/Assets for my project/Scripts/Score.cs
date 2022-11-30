using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public static int scoreValue = 0;
    Text score;
    [SerializeField] Text highScoreText;
    void Start()
    {
        score = GetComponent<Text> ();
    }

    
    void Update()
    {
        score.text = "" + scoreValue;
        CheckHighScore();
    }
    void CheckHighScore()
    {
        if(scoreValue > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", scoreValue);
            UpadateHighScoreText();
        }
    }
    void UpadateHighScoreText()
    {
        highScoreText.text = $"HighScore: {PlayerPrefs.GetInt("HighScore", 0)}";
    }
}
