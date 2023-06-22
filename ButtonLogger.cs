using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonLogger : MonoBehaviour
{
    // public accessible variable showing whether the button has been clicked
    public bool buttonClicked;

    // Start is called before the first frame update
    void Start()
    {
        buttonClicked = false;
    }

    public void OnButtonPress()
    {
        buttonClicked = true;
    }
}
