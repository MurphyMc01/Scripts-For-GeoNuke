using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorMovement : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        float objectPositionY = GameObject.Find("Cursor").transform.position.y;
        float objectPositionX = GameObject.Find("Cursor").transform.position.x;

        if (objectPositionY < 3.5)
        {
            if (Input.GetKeyDown("w") || Input.GetKeyDown("up")) {
                // move 1 up the y axis
                transform.Translate(0f, 0.9f, 0f);
        }
        }

        if (objectPositionX > -8)
        {
            if (Input.GetKeyDown("a") || Input.GetKeyDown("left")) {
                // move 1 down the x axis
                transform.Translate(-0.9f, 0f, 0f);
        }
        }

        if (objectPositionY > -2.5)
        {
            if (Input.GetKeyDown("s") || Input.GetKeyDown("down")) {
                // move 1 down the y axis
                transform.Translate(0f, -0.9f, 0f);
        }
        }

        if (objectPositionX < 1)
        {
            if (Input.GetKeyDown("d") || Input.GetKeyDown("right")) {
                // move 1 up the x axis
                transform.Translate(0.9f, 0f, 0f);
        }
        }


    }
}
