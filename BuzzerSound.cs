using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuzzerSound : MonoBehaviour
{
    // Access the sound object and sound
    public AudioSource audioSource;
    public AudioClip soundClip;

    // Make the GameObject with country generator accessible in multiple functions
    private CountryPositionDictionary countryDictionary;

    // Start is called before the first frame update
    void Start()
    {
        // Find the GameObject with the country genersator script attached
        countryDictionary = GameObject.Find("Cursor").GetComponent<CountryPositionDictionary>();
    }

    // Update is called once per frame
    void Update()
    {
        if (countryDictionary.incorrectGuess == true)
        {
            // Cut off the empty beginning
            audioSource.time = 2.2f;   
            
            // Play the audio clip
            audioSource.Play();
        }
    }
}
