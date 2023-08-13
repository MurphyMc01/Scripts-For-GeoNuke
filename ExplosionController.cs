using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionController : MonoBehaviour
{
    private Animator animator;
    public bool explode;
    private Vector3 cursorLocation;

    public GameObject fire;
    public GameObject smoke;
    public GameObject explosionLight;

    // Make the GameObject with country generator accessible in multiple functions
    private CountryPositionDictionary countryDictionary;

    private void Start()
    {
        // Access the animator
        animator = GetComponent<Animator>();
        // Reset the explosion state
        animator.SetBool("playerGuessed", false);
        fire.SetActive(false);
        smoke.SetActive(false);
        explosionLight.SetActive(false);

        // Find the GameObject with the country genersator script attached
        countryDictionary = GameObject.Find("Cursor").GetComponent<CountryPositionDictionary>();
    }

    private IEnumerator PlayExplosionAnimation()
    {
        // Set up the explosion state
        fire.SetActive(true);
        smoke.SetActive(true);
        explosionLight.SetActive(true);
        animator.SetBool("playerGuessed", true);

        // Wait for the specified duration
        yield return new WaitForSeconds(2.0f);

        // Reset the explosion state
        animator.SetBool("playerGuessed", false);
        fire.SetActive(false);
        smoke.SetActive(false);
        explosionLight.SetActive(false);
    }

    private void Update()
    {
        // Explode if the user is correct
        explode = countryDictionary.correctGuess;

        if (explode)
        {
            // Find the location of the cursor and move there
            cursorLocation = countryDictionary.cursorPosition;
            transform.position = cursorLocation;

            // Start the coroutine to play the explosion animation
            StartCoroutine(PlayExplosionAnimation());

            // Reset the explode flag
            explode = false;
        }
    }
}
