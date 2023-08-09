using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreTracker : MonoBehaviour
{
    // Initialize the score (at 0 points)
    private int score = 0;
    // Declare bool for whether the user is correct
    private bool increaseScore;

    private RandomCountryGenerator countryGenerator;

    // Public which textbox will be changed
    [SerializeField] private TMP_Text scoreBoard;

    // Start is called before the first frame update
    void Start()
    {
        // Find the GameObject with the country genersator script attached
        countryGenerator = GameObject.Find("ButtonLoggerObject").GetComponent<RandomCountryGenerator>();
    }

    // Update is called once per frame
    void Update()
    {
        increaseScore = countryGenerator.nextRound;

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
        scoreBoard.text = score.ToString();
        scoreBoard.color = Color.white;
    }
}
