using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitTheGame : MonoBehaviour
{
    public void QuitGame()
    {
        // Erase high score
        PlayerPrefs.SetInt("playerHighScore", 0);
        // Application.Quit();
        Debug.Log("Quit Game");
    }
}
