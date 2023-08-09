using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Stopwatch : MonoBehaviour
{
    // Public which textbox will be changed
    [SerializeField] private TMP_Text timer;

    public void SetTimerText(int minutes, string roundedSeconds)
    {
        // change text, color
        timer.text = (minutes+":"+roundedSeconds);
        timer.color = Color.white;
    }

    private int minutes = 0;
    private float seconds = 0;
    private bool isRunning = false;
    private float roundedSeconds = 0f;
    private RandomCountryGenerator countryGenerator;

    // Start is called before the first frame update
    void Start()
    {
        // Find the GameObject with the country genersator script attached
        countryGenerator = GameObject.Find("ButtonLoggerObject").GetComponent<RandomCountryGenerator>();
    }

    // Update is called once per frame
    void Update()
    {
        isRunning = countryGenerator.isClicked;
        if (isRunning)
        {
            // Every 1 seconds, add 1 to seconds
            seconds += Time.deltaTime;
            // Round the float to nearest 1
            roundedSeconds = Mathf.Round(seconds);
            // Debug.Log(roundedSeconds);
            if (seconds >= 60.0f)
            {
                minutes++;
                seconds -= 60.0f;
            }
            // Make the seconds two significant figures
            string formattedSeconds = seconds.ToString("00");
            // Print it in text field
            SetTimerText(minutes, formattedSeconds);
        }
    }
}
