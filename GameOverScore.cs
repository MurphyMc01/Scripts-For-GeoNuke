using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameOverScore : MonoBehaviour
{
    public TMP_Text scoreText;
    private int oldScore;
    public int highScore;

    private void Start()
    {
        // Access stored score from last round
        oldScore = PlayerPrefs.GetInt ("player_score");

        highScore = PlayerPrefs.GetInt("playerHighScore");

        // If the user beats their high score
        if (oldScore >= highScore)
        {
            // Update it
            highScore = oldScore;
        }

        // Display it in text field
        scoreText.text = "Score: " + oldScore.ToString() + "   High Score: " + highScore.ToString();   
    }
}
