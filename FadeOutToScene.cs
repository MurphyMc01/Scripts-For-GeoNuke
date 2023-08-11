using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeOutToScene : MonoBehaviour
{
FadeInAndOut fade;

    void Start()
    {
        fade = FindObjectOfType<FadeInAndOut>();
        fade.FadeOut();
    }
}
