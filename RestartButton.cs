using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
    FadeInAndOut fade;

    void Start()
    {
        fade = FindObjectOfType<FadeInAndOut>();
        fade.FadeOut();
    }

    public void OnButtonPress()
    {
        // Change scene (with fade)
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
