using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
    FadeInAndOut fade;
    private GameOverScore scores;

    void Start()
    {
        fade = FindObjectOfType<FadeInAndOut>();
        fade.FadeOut();

        // Get the scores script
        scores = GameObject.Find("Score").GetComponent<GameOverScore>();
    }

    public void OnButtonPress()
    {
        // here I should store my last score before move to level two
        PlayerPrefs.SetInt("playerHighScore", scores.highScore);

        // Change scene (with fade)
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
