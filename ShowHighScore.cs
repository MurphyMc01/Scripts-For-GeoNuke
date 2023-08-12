using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowHighScore : MonoBehaviour
{
    public TMP_Text scoreText;
    private int highScore;
    
    // Start is called before the first frame update
    void Start()
    {
        highScore = PlayerPrefs.GetInt("playerHighScore");
        // Display it in text field
        scoreText.text = "High Score: " + highScore.ToString();
    }
}
