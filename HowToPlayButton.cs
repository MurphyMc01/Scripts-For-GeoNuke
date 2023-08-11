using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HowToPlayButton : MonoBehaviour
{
    public void OnButtonPress()
    {
        // Change scene
        SceneManager.LoadScene(3);
    }
}
