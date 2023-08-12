using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainStrikeTracker : MonoBehaviour
{
    private int strikes = 0;

    // Variables for strike 1
    public GameObject strikeObject1;
    private SpriteRenderer strikeObject1Renderer;

    // Variables for strike 2
    public GameObject strikeObject2;
    private SpriteRenderer strikeObject2Renderer;

    // Variables for strike 3
    public GameObject strikeObject3;
    private SpriteRenderer strikeObject3Renderer;

    public bool gameOver = false;
    private bool userIncorrect = true;

    // Make the GameObject with country generator accessible in multiple functions
    private CountryPositionDictionary countryDictionary;

    // Access the score script
    private ScoreTracker scoreScript;

    private int highScore;

    FadeInAndOut fade;

    // at the start of the game
    void Start()
    {
        // Find the GameObject with the country genersator script attached
        countryDictionary = GameObject.Find("Cursor").GetComponent<CountryPositionDictionary>();

        // Access the score script
        scoreScript = GameObject.Find("Score").GetComponent<ScoreTracker>();

        // Get the SpriteRenderer component of strikeObject1
        strikeObject1Renderer = strikeObject1.GetComponent<SpriteRenderer>();

        // Get the SpriteRenderer component of strikeObject1
        strikeObject2Renderer = strikeObject2.GetComponent<SpriteRenderer>();

        // Get the SpriteRenderer component of strikeObject1
        strikeObject3Renderer = strikeObject3.GetComponent<SpriteRenderer>();

        fade = FindObjectOfType<FadeInAndOut>();

        // Access high score
        highScore = PlayerPrefs.GetInt ("playerHighScore");
    }

    public IEnumerator ChangeScene()
    {
        fade.FadeIn();
        yield return new WaitForSeconds(0.5f);
        // Show game over screen
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // Update is called once per frame
    void Update()
    {
        // Access the correctGuess boolean
        userIncorrect = countryDictionary.addStrike;

        // If the user gets a country wrong
        if (userIncorrect == true && gameOver != true)
        {
            // Add a strike (until the game is over at 3)
            strikes++;
            Debug.Log(strikes);
        }

        // Determine the strike number based on the int strike value
        if (strikes == 1)
        {
            strikeObject1Renderer.color = Color.red;
        }
        else if (strikes == 2)
        {
            strikeObject2Renderer.color = Color.red;
        }
        else if (strikes == 3)
        {
            strikeObject3Renderer.color = Color.red;
            // Bool for ending game
            gameOver = true;

            // here I should store my last score before move to level two
            PlayerPrefs.SetInt ("player_score", scoreScript.score);

            // Change scene (with fade)
            StartCoroutine(ChangeScene());
        }
    }
}
