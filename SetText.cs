using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SetText : MonoBehaviour
{
    // Public which textbox will be changed
    [SerializeField] private TMP_Text textbox;

    // Make a box for the country generator object to be dragged into / accessible in
    public GameObject countryGameObject;

    // Make the GameObject with country generator accessible in multiple functions
    private RandomCountryGenerator countryGenerator;

    // run at the start of the game
    void Start() 
    {
        // Find the GameObject with the country genersator script attached
        countryGenerator = countryGameObject.GetComponent<RandomCountryGenerator>();
    }

    // Run 60 times per second
    void Update()
    {
        // access the public object of the selected country from the country generator script
        string countryValue = countryGenerator.country;
        if (countryValue != textbox.text)
        {
            SetTextboxText(countryValue);
        }
    }

    // When the text is changed
    public void SetTextboxText(string countryValue)
    {
        // change text, color, font size
        textbox.text = countryValue;
    }
}
