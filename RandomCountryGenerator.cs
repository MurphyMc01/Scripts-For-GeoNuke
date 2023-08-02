using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RandomCountryGenerator : MonoBehaviour
{
    // make variable public and accessible in unity engine
    public string country;
    public bool nextRound = false;
    public bool isClicked = false;
    public bool generateCountry = false;
    public Button button;
    public TMP_Text buttonText;

    // Make the GameObject with country generator accessible in multiple functions
    private CountryPositionDictionary countryDictionary;
    
    // List of countries to select from
    public List<string> CountriesInTheWorld = new List<string> 
    {
    "Afghanistan",
    "Albania",
    "Algeria",
    "Andorra",
    "Angola",
    "Antigua and Barbuda",
    "Argentina",
    "Armenia",
    "Australia",
    "Austria",
    "Azerbaijan",
    "Bahamas",
    "Bahrain",
    "Bangladesh",
    "Barbados",
    "Belarus",
    "Belgium",
    "Belize",
    "Benin",
    "Bhutan",
    "Bolivia",
    "Bosnia and Herzegovina",
    "Botswana",
    "Brazil",
    "Brunei",
    "Bulgaria",
    "Burkina Faso",
    "Burundi",
    "Cambodia",
    "Cameroon",
    "Canada",
    "Cape Verde",
    "Central African Republic",
    "Chad",
    "Chile",
    "China",
    "Colombia",
    "Comoros",
    "Democratic Republic of Congo",
    "Republic of Congo",
    "Costa Rica",
    "Ivory Coast",
    "Croatia",
    "Cuba",
    "Cyprus",
    "Czech Republic",
    "Denmark",
    "Djibouti",
    "Dominica",
    "Dominican Republic",
    "East Timor",
    "Ecuador",
    "Egypt",
    "El Salvador",
    "Equatorial Guinea",
    "Eritrea",
    "Estonia",
    "Eswatini",
    "Ethiopia",
    "Fiji",
    "Finland",
    "France",
    "Gabon",
    "Gambia",
    "Georgia",
    "Germany",
    "Ghana",
    "Greece",
    "Grenada",
    "Guatemala",
    "Guinea",
    "Guinea Bissau",
    "Guyana",
    "Haiti",
    "Honduras",
    "Hungary",
    "Iceland",
    "India",
    "Indonesia",
    "Iran",
    "Iraq",
    "Ireland",
    "Israel",
    "Italy",
    "Jamaica",
    "Japan",
    "Jordan",
    "Kazakhstan",
    "Kenya",
    "Kiribati",
    "Kosovo",
    "Kuwait",
    "Kyrgyzstan",
    "Laos",
    "Latvia",
    "Lebanon",
    "Lesotho",
    "Liberia",
    "Libya",
    "Liechtenstein",
    "Lithuania",
    "Luxembourg",
    "Macedonia",
    "Madagascar",
    "Malawi",
    "Malaysia",
    "Maldives",
    "Mali",
    "Malta",
    "Marshall Islands",
    "Mauritania",
    "Mauritius",
    "Mexico",
    "Micronesia",
    "Moldova",
    "Monaco",
    "Mongolia",
    "Montenegro",
    "Morocco",
    "Mozambique",
    "Myanmar",
    "Namibia",
    "Nauru",
    "Nepal",
    "Netherlands",
    "New Zealand",
    "Nicaragua",
    "Niger",
    "Nigeria",
    "North Korea",
    "Norway",
    "Oman",
    "Pakistan",
    "Palau",
    "Palestine",
    "Panama",
    "Papua New Guinea",
    "Paraguay",
    "Peru",
    "Philippines",
    "Poland",
    "Portugal",
    "Qatar",
    "Romania",
    "Russia",
    "Rwanda",
    "Saint Kitts and Nevis",
    "Saint Lucia",
    "Saint Vincent and the Grenadines",
    "Samoa",
    "San Marino",
    "Sao Tome and Principe",
    "Saudi Arabia",
    "Senegal",
    "Serbia",
    "Seychelles",
    "Sierra Leone",
    "Singapore",
    "Slovakia",
    "Slovenia",
    "Solomon Islands",
    "Somalia",
    "South Africa",
    "South Korea",
    "South Sudan",
    "Spain",
    "Sri Lanka",
    "Sudan",
    "Suriname",
    "Sweden",
    "Switzerland",
    "Syria",
    "Taiwan",
    "Tajikistan",
    "Tanzania",
    "Thailand",
    "Togo",
    "Tonga",
    "Trinidad and Tobago",
    "Tunisia",
    "Turkey",
    "Turkmenistan",
    "Tuvalu",
    "Uganda",
    "Ukraine",
    "United Arab Emirates",
    "United Kingdom",
    "United States",
    "Uruguay",
    "Uzbekistan",
    "Vanuatu",
    "Vatican City",
    "Venezuela",
    "Vietnam",
    "Yemen",
    "Zambia",
    "Zimbabwe"
    };
    
    // at the start of the game
    void Start()
    {
      // Find the GameObject with the country genersator script attached
      countryDictionary = GameObject.Find("Cursor").GetComponent<CountryPositionDictionary>();
    }
    
    // every frame
    void Update()
    {
      // If the button is clicked (or a new round)
      if (generateCountry == true) {
        // Choose a random number from 0 to the number of countries in the list
        int randomIndex = UnityEngine.Random.Range(0, CountriesInTheWorld.Count);
        // Find the country with that index value and return it as a string
        country = CountriesInTheWorld[randomIndex];
        // Display the random country in the console.
        Debug.Log(country);
        // button is clicked
        isClicked = true;
        // Dont generate a new country
        generateCountry = false;
      }

      // Access the correctGuess boolean
      nextRound = countryDictionary.correctGuess;
      // If they are correct
      if (nextRound == true)
      {
        // Reset the button and user movement
        isClicked = false;
        // Move onto next round
        generateCountry = true;
      }
      
      if (isClicked == true)
      {
        // make the button unclickable and change colour and text
        button.interactable = false;
        buttonText.text = "";
        buttonText.color = Color.white;
        buttonText.fontSize = 18;
        button.image.color = Color.red;
      }
      // if it hasn't, or the game has reset
      else
      {
          // bring the button back
          button.interactable = true;
          buttonText.text = "";
          buttonText.color = Color.black;
          buttonText.fontSize = 18;
          button.image.color = Color.green;
      } 
    }

    // When the button is clicked
    public void OnButtonPress() {
      generateCountry = true;
    }
}