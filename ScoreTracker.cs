using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreTracker : MonoBehaviour
{
    // Initialize the score (at 0 points)
    public int score = 0;
    // Declare bool for whether the user is correct
    private bool increaseScore;

    private CountryPositionDictionary countryDictionary;

    // Public which textbox will be changed
    [SerializeField] private TMP_Text scoreBoard;

    // Start is called before the first frame update
    void Start()
    {
        // Find the GameObject with the country genersator script attached
        countryDictionary = GameObject.Find("Cursor").GetComponent<CountryPositionDictionary>();
    }

    // Update is called once per frame
    void Update()
    {
        increaseScore = countryDictionary.correctGuess;

        // If the user gets a country correct
        if (increaseScore == true)
        {
            // Add 1 to score
            score++;
            // Print it in text field
            SetscoreBoardText(score);
        }
    }

    public void SetscoreBoardText(int score)
    {
        // string stringScore = score.ToString();
        // change text, color, font size
        scoreBoard.text = "Score: "+score.ToString();
        scoreBoard.color = Color.white;
    }
}
