using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorMovement : MonoBehaviour
{
    // Make a box for the country generator object to be dragged into / accessible in
    public GameObject countryGameObject;

    // Make the GameObject with country generator accessible in multiple functions
    private RandomCountryGenerator countryGenerator;

    // Access gameobject for strikes
    public GameObject strikeGameObject;

    // run at the start of the game
    void Start() 
    {
        // Find the GameObject with the country genersator script attached
        countryGenerator = countryGameObject.GetComponent<RandomCountryGenerator>();
    }

    // Update is called once per frame
    void Update()
    {
        // access the public isClicked boolean
        bool gameActive = countryGenerator.isClicked;

        float objectPositionY = GameObject.Find("Cursor").transform.position.y;
        float objectPositionX = GameObject.Find("Cursor").transform.position.x;

        if (gameActive == true)
        {
            if (objectPositionY < 3.5)
            {
                if (Input.GetKeyDown("w") || Input.GetKeyDown("up")) {
                    // move 1 up the y axis
                    transform.Translate(0f, 0.9f, 0f);
                }
            }

            if (objectPositionX > -7)
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

            if (objectPositionX < 2)
            {
                if (Input.GetKeyDown("d") || Input.GetKeyDown("right")) {
                    // move 1 up the x axis
                    transform.Translate(0.9f, 0f, 0f);
                }
            }
        }
    }
}
