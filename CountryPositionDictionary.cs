using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountryPositionDictionary : MonoBehaviour
{
    private GameObject cursorObject;
    private Vector3 cursorPosition;
    // Start is called before the first frame update
    void Start()
    {
        // Find the object named "Cursor" in the scene
        cursorObject = GameObject.Find("Cursor");

        // Check if the cursor object is found
        if (cursorObject == null)
        {
            Debug.LogError("Cursor object not found in the scene!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Check if the cursor object is found
        if (cursorObject != null)
        {
            // Retrieve the cursor object's position and save it as a Vector3
            cursorPosition = cursorObject.transform.position;

            // Log the cursor position
            Debug.Log("Cursor Position: " + cursorPosition);
        }
    }
}
