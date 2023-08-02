using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountryPositionDictionary : MonoBehaviour
{
    private Vector3 cursorPosition;
    public GameObject cursorObject;

    // make public variable for enter keys
    public bool enterKeyPressed = false;

    // accessible bool for whether the user is correct
    public bool correctGuess;

    // Make a box for the country generator object to be dragged into / accessible in
    public GameObject countryGameObject;

    // Make the GameObject with country generator accessible in multiple functions
    private RandomCountryGenerator countryGenerator;

    // Declare the dictionary
    Dictionary<Vector3, List<string>> countryLocationDictionary;

    // Define a tolerance level for position comparison
    private float positionTolerance = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        // Initialize the dictionary
        countryLocationDictionary = new Dictionary<Vector3, List<string>>();

        // Add entries to the dictionary
        // Row A
        // A1
        Vector3 coordinatesA1 = new Vector3(-8.45f, 3.55f, 0.00f);
        List<string> countriesA1 = new List<string>() { "" };
        countryLocationDictionary.Add(coordinatesA1, countriesA1);

        // A2
        Vector3 coordinatesA2 = new Vector3(-7.55f, 3.55f, 0.00f);
        List<string> countriesA2 = new List<string>() { "" };
        countryLocationDictionary.Add(coordinatesA2, countriesA2);

        // A3
        Vector3 coordinatesA3 = new Vector3(-6.65f, 3.55f, 0.00f);
        List<string> countriesA3 = new List<string>() { "" };
        countryLocationDictionary.Add(coordinatesA3, countriesA3);

        // A4
        Vector3 coordinatesA4 = new Vector3(-5.75f, 3.55f, 0.00f);
        List<string> countriesA4 = new List<string>() { "" };
        countryLocationDictionary.Add(coordinatesA4, countriesA4);

        // A5
        Vector3 coordinatesA5 = new Vector3(-4.85f, 3.55f, 0.00f);
        List<string> countriesA5 = new List<string>() { "" };
        countryLocationDictionary.Add(coordinatesA5, countriesA5);

        // A6
        Vector3 coordinatesA6 = new Vector3(-3.95f, 3.55f, 0.00f);
        List<string> countriesA6 = new List<string>() { "" };
        countryLocationDictionary.Add(coordinatesA6, countriesA6);

        // A7
        Vector3 coordinatesA7 = new Vector3(-3.05f, 3.55f, 0.00f);
        List<string> countriesA7 = new List<string>() { "" };
        countryLocationDictionary.Add(coordinatesA7, countriesA7);

        // A8
        Vector3 coordinatesA8 = new Vector3(-2.15f, 3.55f, 0.00f);
        List<string> countriesA8 = new List<string>() { "" };
        countryLocationDictionary.Add(coordinatesA8, countriesA8);

        // A9
        Vector3 coordinatesA9 = new Vector3(-1.25f, 3.55f, 0.00f);
        List<string> countriesA9 = new List<string>() { "" };
        countryLocationDictionary.Add(coordinatesA9, countriesA9);

        // A10
        Vector3 coordinatesA10 = new Vector3(-0.35f, 3.55f, 0.00f);
        List<string> countriesA10 = new List<string>() { "" };
        countryLocationDictionary.Add(coordinatesA10, countriesA10);

        // A11
        Vector3 coordinatesA11 = new Vector3(0.55f, 3.55f, 0.00f);
        List<string> countriesA11 = new List<string>() { "" };
        countryLocationDictionary.Add(coordinatesA11, countriesA11);

        // A12
        Vector3 coordinatesA12 = new Vector3(1.45f, 3.55f, 0.00f);
        List<string> countriesA12 = new List<string>() { "" };
        countryLocationDictionary.Add(coordinatesA12, countriesA12);
        // Row B
        // B1
        Vector3 coordinatesB1 = new Vector3(-8.45f, 2.65f, 0.00f);
        List<string> countriesB1 = new List<string>() { "" };
        countryLocationDictionary.Add(coordinatesB1, countriesB1);

        // B2
        Vector3 coordinatesB2 = new Vector3(-7.55f, 2.65f, 0.00f);
        List<string> countriesB2 = new List<string>() { "" };
        countryLocationDictionary.Add(coordinatesB2, countriesB2);

        // B3
        Vector3 coordinatesB3 = new Vector3(-6.65f, 2.65f, 0.00f);
        List<string> countriesB3 = new List<string>() { "" };
        countryLocationDictionary.Add(coordinatesB3, countriesB3);

        // B4
        Vector3 coordinatesB4 = new Vector3(-5.75f, 2.65f, 0.00f);
        List<string> countriesB4 = new List<string>() { "" };
        countryLocationDictionary.Add(coordinatesB4, countriesB4);

        // B5
        Vector3 coordinatesB5 = new Vector3(-4.85f, 2.65f, 0.00f);
        List<string> countriesB5 = new List<string>() { "" };
        countryLocationDictionary.Add(coordinatesB5, countriesB5);

        // B6
        Vector3 coordinatesB6 = new Vector3(-3.95f, 2.65f, 0.00f);
        List<string> countriesB6 = new List<string>() { "" };
        countryLocationDictionary.Add(coordinatesB6, countriesB6);

        // B7
        Vector3 coordinatesB7 = new Vector3(-3.05f, 2.65f, 0.00f);
        List<string> countriesB7 = new List<string>() { "" };
        countryLocationDictionary.Add(coordinatesB7, countriesB7);

        // B8
        Vector3 coordinatesB8 = new Vector3(-2.15f, 2.65f, 0.00f);
        List<string> countriesB8 = new List<string>() { "" };
        countryLocationDictionary.Add(coordinatesB8, countriesB8);

        // B9
        Vector3 coordinatesB9 = new Vector3(-1.25f, 2.65f, 0.00f);
        List<string> countriesB9 = new List<string>() { "" };
        countryLocationDictionary.Add(coordinatesB9, countriesB9);

        // B10
        Vector3 coordinatesB10 = new Vector3(-0.35f, 2.65f, 0.00f);
        List<string> countriesB10 = new List<string>() { "" };
        countryLocationDictionary.Add(coordinatesB10, countriesB10);

        // B11
        Vector3 coordinatesB11 = new Vector3(0.55f, 2.65f, 0.00f);
        List<string> countriesB11 = new List<string>() { "" };
        countryLocationDictionary.Add(coordinatesB11, countriesB11);

        // B12
        Vector3 coordinatesB12 = new Vector3(1.45f, 2.65f, 0.00f);
        List<string> countriesB12 = new List<string>() { "" };
        countryLocationDictionary.Add(coordinatesB12, countriesB12);
        // Row C
        // C1
        Vector3 coordinatesC1 = new Vector3(-8.45f, 1.75f, 0.00f);
        List<string> countriesC1 = new List<string>() { "" };
        countryLocationDictionary.Add(coordinatesC1, countriesC1);

        // C2
        Vector3 coordinatesC2 = new Vector3(-7.55f, 1.75f, 0.00f);
        List<string> countriesC2 = new List<string>() { "" };
        countryLocationDictionary.Add(coordinatesC2, countriesC2);

        // C3
        Vector3 coordinatesC3 = new Vector3(-6.65f, 1.75f, 0.00f);
        List<string> countriesC3 = new List<string>() { "" };
        countryLocationDictionary.Add(coordinatesC3, countriesC3);

        // C4
        Vector3 coordinatesC4 = new Vector3(-5.75f, 1.75f, 0.00f);
        List<string> countriesC4 = new List<string>() { "" };
        countryLocationDictionary.Add(coordinatesC4, countriesC4);

        // C5
        Vector3 coordinatesC5 = new Vector3(-4.85f, 1.75f, 0.00f);
        List<string> countriesC5 = new List<string>() { "" };
        countryLocationDictionary.Add(coordinatesC5, countriesC5);

        // C6
        Vector3 coordinatesC6 = new Vector3(-3.95f, 1.75f, 0.00f);
        List<string> countriesC6 = new List<string>() { "iceland" };
        countryLocationDictionary.Add(coordinatesC6, countriesC6);

        // C7
        Vector3 coordinatesC7 = new Vector3(-3.05f, 1.75f, 0.00f);
        List<string> countriesC7 = new List<string>() { "finland", "sweden" };
        countryLocationDictionary.Add(coordinatesC7, countriesC7);

        // C8
        Vector3 coordinatesC8 = new Vector3(-2.15f, 1.75f, 0.00f);
        List<string> countriesC8 = new List<string>() { "" };
        countryLocationDictionary.Add(coordinatesC8, countriesC8);

        // C9
        Vector3 coordinatesC9 = new Vector3(-1.25f, 1.75f, 0.00f);
        List<string> countriesC9 = new List<string>() { "russia" };
        countryLocationDictionary.Add(coordinatesC9, countriesC9);

        // C10
        Vector3 coordinatesC10 = new Vector3(-0.35f, 1.75f, 0.00f);
        List<string> countriesC10 = new List<string>() { "" };
        countryLocationDictionary.Add(coordinatesC10, countriesC10);

        // C11
        Vector3 coordinatesC11 = new Vector3(0.55f, 1.75f, 0.00f);
        List<string> countriesC11 = new List<string>() { "" };
        countryLocationDictionary.Add(coordinatesC11, countriesC11);

        // C12
        Vector3 coordinatesC12 = new Vector3(1.45f, 1.75f, 0.00f);
        List<string> countriesC12 = new List<string>() { "" };
        countryLocationDictionary.Add(coordinatesC12, countriesC12);
        // Row D
        // D1
        Vector3 coordinatesD1 = new Vector3(-8.45f, 0.85f, 0.00f);
        List<string> countriesD1 = new List<string>() { "" };
        countryLocationDictionary.Add(coordinatesD1, countriesD1);

        // D2
        Vector3 coordinatesD2 = new Vector3(-7.55f, 0.85f, 0.00f);
        List<string> countriesD2 = new List<string>() { "" };
        countryLocationDictionary.Add(coordinatesD2, countriesD2);

        // D3
        Vector3 coordinatesD3 = new Vector3(-6.65f, 0.85f, 0.00f);
        List<string> countriesD3 = new List<string>() { "canada" };
        countryLocationDictionary.Add(coordinatesD3, countriesD3);

        // D4
        Vector3 coordinatesD4 = new Vector3(-5.75f, 0.85f, 0.00f);
        List<string> countriesD4 = new List<string>() { "" };
        countryLocationDictionary.Add(coordinatesD4, countriesD4);

        // D5
        Vector3 coordinatesD5 = new Vector3(-4.85f, 0.85f, 0.00f);
        List<string> countriesD5 = new List<string>() { "" };
        countryLocationDictionary.Add(coordinatesD5, countriesD5);

        // D6
        Vector3 coordinatesD6 = new Vector3(-3.95f, 0.85f, 0.00f);
        List<string> countriesD6 = new List<string>() { "belgium", "denmark", "france", "germany", "ireland", "liechtenstein", "luxembourg", "netherlands", "norway", "switzerland", "unitedkingdom" };
        countryLocationDictionary.Add(coordinatesD6, countriesD6);

        // D7
        Vector3 coordinatesD7 = new Vector3(-3.05f, 0.85f, 0.00f);
        List<string> countriesD7 = new List<string>() { "austria", "belarus", "czechrepublic", "estonia", "hungary", "latvia", "lithuania", "moldova", "ukraine", "poland", "slovakia", "romania", "slovenia" };
        countryLocationDictionary.Add(coordinatesD7, countriesD7);

        // D8
        Vector3 coordinatesD8 = new Vector3(-2.15f, 0.85f, 0.00f);
        List<string> countriesD8 = new List<string>() { "kazakhstan" };
        countryLocationDictionary.Add(coordinatesD8, countriesD8);

        // D9
        Vector3 coordinatesD9 = new Vector3(-1.25f, 0.85f, 0.00f);
        List<string> countriesD9 = new List<string>() { "mongolia" };
        countryLocationDictionary.Add(coordinatesD9, countriesD9);

        // D10
        Vector3 coordinatesD10 = new Vector3(-0.35f, 0.85f, 0.00f);
        List<string> countriesD10 = new List<string>() { "" };
        countryLocationDictionary.Add(coordinatesD10, countriesD10);

        // D11
        Vector3 coordinatesD11 = new Vector3(0.55f, 0.85f, 0.00f);
        List<string> countriesD11 = new List<string>() { "northkorea", "southkorea" };
        countryLocationDictionary.Add(coordinatesD11, countriesD11);

        // D12
        Vector3 coordinatesD12 = new Vector3(1.45f, 0.85f, 0.00f);
        List<string> countriesD12 = new List<string>() { "" };
        countryLocationDictionary.Add(coordinatesD12, countriesD12);
        // Row E
        // E1
        Vector3 coordinatesE1 = new Vector3(-8.45f, -0.05f, 0.00f);
        List<string> countriesE1 = new List<string>() { "" };
        countryLocationDictionary.Add(coordinatesE1, countriesE1);

        // E2
        Vector3 coordinatesE2 = new Vector3(-7.55f, -0.05f, 0.00f);
        List<string> countriesE2 = new List<string>() { "" };
        countryLocationDictionary.Add(coordinatesE2, countriesE2);

        // E3
        Vector3 coordinatesE3 = new Vector3(-6.65f, -0.05f, 0.00f);
        List<string> countriesE3 = new List<string>() { "mexico", "unitedstates" };
        countryLocationDictionary.Add(coordinatesE3, countriesE3);

        // E4
        Vector3 coordinatesE4 = new Vector3(-5.75f, -0.05f, 0.00f);
        List<string> countriesE4 = new List<string>() { "bahamas", "cuba", "dominicanrepublic", "haiti" };
        countryLocationDictionary.Add(coordinatesE4, countriesE4);

        // E5
        Vector3 coordinatesE5 = new Vector3(-4.85f, -0.05f, 0.00f);
        List<string> countriesE5 = new List<string>() { "" };
        countryLocationDictionary.Add(coordinatesE5, countriesE5);

        // E6
        Vector3 coordinatesE6 = new Vector3(-3.95f, -0.05f, 0.00f);
        List<string> countriesE6 = new List<string>() { "algeria", "andorra", "mali", "spain", "portugal", "malta", "morocco", "algeria", "mauritania", "tunisia", "monaco", "niger" };
        countryLocationDictionary.Add(coordinatesE6, countriesE6);

        // E7
        Vector3 coordinatesE7 = new Vector3(-3.05f, -0.05f, 0.00f);
        List<string> countriesE7 = new List<string>() { "albania", "bosniaandherzegovina", "bulgaria", "croatia", "cyprus", "egypt", "greece", "israel", "italy", "jordan", "kosovo", "lebanon", "libya", "macedonia", "montenegro", "palestine", "syria", "sanmarino", "vaticancity", "serbia", "sudan", "turkey" };
        countryLocationDictionary.Add(coordinatesE7, countriesE7);

        // E8
        Vector3 coordinatesE8 = new Vector3(-2.15f, -0.05f, 0.00f);
        List<string> countriesE8 = new List<string>() { "afghanistan", "armenia", "azerbaijan", "bahrain", "georgia", "iran", "iraq", "kuwait", "kyrgyzstam", "oman", "unitedarabemirates", "pakistan", "qatar", "saudiarabia", "tajikistan", "turkmenistan", "uzbekistan" };
        countryLocationDictionary.Add(coordinatesE8, countriesE8);

        // E9
        Vector3 coordinatesE9 = new Vector3(-1.25f, -0.05f, 0.00f);
        List<string> countriesE9 = new List<string>() { "bangladesh", "bhutan", "china", "india", "laos", "myanmar", "nepal" };
        countryLocationDictionary.Add(coordinatesE9, countriesE9);

        // E10
        Vector3 coordinatesE10 = new Vector3(-0.35f, -0.05f, 0.00f);
        List<string> countriesE10 = new List<string>() { "taiwan" };
        countryLocationDictionary.Add(coordinatesE10, countriesE10);

        // E11
        Vector3 coordinatesE11 = new Vector3(0.55f, -0.05f, 0.00f);
        List<string> countriesE11 = new List<string>() { "japan" };
        countryLocationDictionary.Add(coordinatesE11, countriesE11);

        // E12
        Vector3 coordinatesE12 = new Vector3(1.45f, -0.05f, 0.00f);
        List<string> countriesE12 = new List<string>() { "" };
        countryLocationDictionary.Add(coordinatesE12, countriesE12);
        // Row F
        // F1
        Vector3 coordinatesF1 = new Vector3(-8.45f, -0.95f, 0.00f);
        List<string> countriesF1 = new List<string>() { "" };
        countryLocationDictionary.Add(coordinatesF1, countriesF1);

        // F2
        Vector3 coordinatesF2 = new Vector3(-7.55f, -0.95f, 0.00f);
        List<string> countriesF2 = new List<string>() { "" };
        countryLocationDictionary.Add(coordinatesF2, countriesF2);

        // F3
        Vector3 coordinatesF3 = new Vector3(-6.65f, -0.95f, 0.00f);
        List<string> countriesF3 = new List<string>() { "belize", "costarica", "elsalvador", "guatemala", "honduras", "nicaragua" };
        countryLocationDictionary.Add(coordinatesF3, countriesF3);

        // F4
        Vector3 coordinatesF4 = new Vector3(-5.75f, -0.95f, 0.00f);
        List<string> countriesF4 = new List<string>() { "antiguaandbarbuda", "barbados", "brazil", "colombia", "dominica", "ecuador", "grenada", "guyana", "jamaica", "panama", "peru", "suriname", "venezuela", "saintkittsandnevis", "saintlucia", "saintvincentandthegrenadines", "trinidadandtobago" };
        countryLocationDictionary.Add(coordinatesF4, countriesF4);

        // F5
        Vector3 coordinatesF5 = new Vector3(-4.85f, -0.95f, 0.00f);
        List<string> countriesF5 = new List<string>() { "" };
        countryLocationDictionary.Add(coordinatesF5, countriesF5);

        // F6
        Vector3 coordinatesF6 = new Vector3(-3.95f, -0.95f, 0.00f);
        List<string> countriesF6 = new List<string>() { "benin", "burkinafaso", "capeverde", "ivorycoast", "ghana", "guinea", "guineabissau", "liberia", "nigeria", "saotomeandprincipe", "senegal", "sierraleone", "togo" };
        countryLocationDictionary.Add(coordinatesF6, countriesF6);

        // F7
        Vector3 coordinatesF7 = new Vector3(-3.05f, -0.95f, 0.00f);
        List<string> countriesF7 = new List<string>() { "angola", "burundi", "cameroon", "centralafricanrepublic", "chad", "comoros", "democraticrepublicofcongo", "republicofcongo", "equatorialguinea", "eritrea", "ethiopia", "gabon", "kenya", "rwanda", "southsudan", "uganda", "tanzania" };
        countryLocationDictionary.Add(coordinatesF7, countriesF7);

        // F8
        Vector3 coordinatesF8 = new Vector3(-2.15f, -0.95f, 0.00f);
        List<string> countriesF8 = new List<string>() { "djibouti", "maldives", "seychelles", "somalia", "yemen" };
        countryLocationDictionary.Add(coordinatesF8, countriesF8);

        // F9
        Vector3 coordinatesF9 = new Vector3(-1.25f, -0.95f, 0.00f);
        List<string> countriesF9 = new List<string>() { "cambodia", "malaysia", "singapore", "srilanka", "thailand" };
        countryLocationDictionary.Add(coordinatesF9, countriesF9);

        // F10
        Vector3 coordinatesF10 = new Vector3(-0.35f, -0.95f, 0.00f);
        List<string> countriesF10 = new List<string>() { "brunei", "easttimor", "indonesia", "palau", "philippines", "vietnam" };
        countryLocationDictionary.Add(coordinatesF10, countriesF10);

        // F11
        Vector3 coordinatesF11 = new Vector3(0.55f, -0.95f, 0.00f);
        List<string> countriesF11 = new List<string>() { "micronesia", "nauru", "papuanewguinea", "solomonislands" };
        countryLocationDictionary.Add(coordinatesF11, countriesF11);

        // F12
        Vector3 coordinatesF12 = new Vector3(1.45f, -0.95f, 0.00f);
        List<string> countriesF12 = new List<string>() { "kiribati", "marshallislands", "tuvalu" };
        countryLocationDictionary.Add(coordinatesF12, countriesF12);
        // Row G
        // G1
        Vector3 coordinatesG1 = new Vector3(-8.45f, -1.85f, 0.00f);
        List<string> countriesG1 = new List<string>() { "" };
        countryLocationDictionary.Add(coordinatesG1, countriesG1);

        // G2
        Vector3 coordinatesG2 = new Vector3(-7.55f, -1.85f, 0.00f);
        List<string> countriesG2 = new List<string>() { "" };
        countryLocationDictionary.Add(coordinatesG2, countriesG2);

        // G3
        Vector3 coordinatesG3 = new Vector3(-6.65f, -1.85f, 0.00f);
        List<string> countriesG3 = new List<string>() { "" };
        countryLocationDictionary.Add(coordinatesG3, countriesG3);

        // G4
        Vector3 coordinatesG4 = new Vector3(-5.75f, -1.85f, 0.00f);
        List<string> countriesG4 = new List<string>() { "argentina", "bolivia", "chile", "paraguay", "uruguay" };
        countryLocationDictionary.Add(coordinatesG4, countriesG4);

        // G5
        Vector3 coordinatesG5 = new Vector3(-4.85f, -1.85f, 0.00f);
        List<string> countriesG5 = new List<string>() { "" };
        countryLocationDictionary.Add(coordinatesG5, countriesG5);

        // G6
        Vector3 coordinatesG6 = new Vector3(-3.95f, -1.85f, 0.00f);
        List<string> countriesG6 = new List<string>() { "" };
        countryLocationDictionary.Add(coordinatesG6, countriesG6);

        // G7
        Vector3 coordinatesG7 = new Vector3(-3.05f, -1.85f, 0.00f);
        List<string> countriesG7 = new List<string>() { "botswana", "eswatini", "lesotho", "southafrica", "malawi", "mozambique", "zimbabwe", "zambia", "namibia", "" };
        countryLocationDictionary.Add(coordinatesG7, countriesG7);

        // G8
        Vector3 coordinatesG8 = new Vector3(-2.15f, -1.85f, 0.00f);
        List<string> countriesG8 = new List<string>() { "madagascar", "mauritius" };
        countryLocationDictionary.Add(coordinatesG8, countriesG8);

        // G9
        Vector3 coordinatesG9 = new Vector3(-1.25f, -1.85f, 0.00f);
        List<string> countriesG9 = new List<string>() { "" };
        countryLocationDictionary.Add(coordinatesG9, countriesG9);

        // G10
        Vector3 coordinatesG10 = new Vector3(-0.35f, -1.85f, 0.00f);
        List<string> countriesG10 = new List<string>() { "australia" };
        countryLocationDictionary.Add(coordinatesG10, countriesG10);

        // G11
        Vector3 coordinatesG11 = new Vector3(0.55f, -1.85f, 0.00f);
        List<string> countriesG11 = new List<string>() { "vanuatu" };
        countryLocationDictionary.Add(coordinatesG11, countriesG11);

        // G12
        Vector3 coordinatesG12 = new Vector3(1.45f, -1.85f, 0.00f);
        List<string> countriesG12 = new List<string>() { "fiji", "samoa", "tonga" };
        countryLocationDictionary.Add(coordinatesG12, countriesG12);
        // Row H
        // H1
        Vector3 coordinatesH1 = new Vector3(-8.45f, -2.75f, 0.00f);
        List<string> countriesH1 = new List<string>() { "" };
        countryLocationDictionary.Add(coordinatesH1, countriesH1);

        // H2
        Vector3 coordinatesH2 = new Vector3(-7.55f, -2.75f, 0.00f);
        List<string> countriesH2 = new List<string>() { "" };
        countryLocationDictionary.Add(coordinatesH2, countriesH2);

        // H3
        Vector3 coordinatesH3 = new Vector3(-6.65f, -2.75f, 0.00f);
        List<string> countriesH3 = new List<string>() { "" };
        countryLocationDictionary.Add(coordinatesH3, countriesH3);

        // H4
        Vector3 coordinatesH4 = new Vector3(-5.75f, -2.75f, 0.00f);
        List<string> countriesH4 = new List<string>() { "" };
        countryLocationDictionary.Add(coordinatesH4, countriesH4);

        // H5
        Vector3 coordinatesH5 = new Vector3(-4.85f, -2.75f, 0.00f);
        List<string> countriesH5 = new List<string>() { "" };
        countryLocationDictionary.Add(coordinatesH5, countriesH5);

        // H6
        Vector3 coordinatesH6 = new Vector3(-3.95f, -2.75f, 0.00f);
        List<string> countriesH6 = new List<string>() { "" };
        countryLocationDictionary.Add(coordinatesH6, countriesH6);

        // H7
        Vector3 coordinatesH7 = new Vector3(-3.05f, -2.75f, 0.00f);
        List<string> countriesH7 = new List<string>() { "" };
        countryLocationDictionary.Add(coordinatesH7, countriesH7);

        // H8
        Vector3 coordinatesH8 = new Vector3(-2.15f, -2.75f, 0.00f);
        List<string> countriesH8 = new List<string>() { "" };
        countryLocationDictionary.Add(coordinatesH8, countriesH8);

        // H9
        Vector3 coordinatesH9 = new Vector3(-1.25f, -2.75f, 0.00f);
        List<string> countriesH9 = new List<string>() { "" };
        countryLocationDictionary.Add(coordinatesH9, countriesH9);

        // H10
        Vector3 coordinatesH10 = new Vector3(-0.35f, -2.75f, 0.00f);
        List<string> countriesH10 = new List<string>() { "" };
        countryLocationDictionary.Add(coordinatesH10, countriesH10);

        // H11
        Vector3 coordinatesH11 = new Vector3(0.55f, -2.75f, 0.00f);
        List<string> countriesH11 = new List<string>() { "" };
        countryLocationDictionary.Add(coordinatesH11, countriesH11);

        // H12
        Vector3 coordinatesH12 = new Vector3(1.45f, -2.75f, 0.00f);
        List<string> countriesH12 = new List<string>() { "newzealand" };
        countryLocationDictionary.Add(coordinatesH12, countriesH12);

        // Find the GameObject with the country genersator script attached
        countryGenerator = countryGameObject.GetComponent<RandomCountryGenerator>();

        // Check if the cursor object is found
        if (cursorObject == null)
        {
            Debug.LogError("Cursor object not found in the scene!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        // reset correctGuess
        correctGuess = false;

        // access the public object of the selected country from the country generator script
        string countryValue = countryGenerator.country;
        string countryValueLowercase = string.Join("", countryValue.Split(' ')).ToLower();

        // Check whether the user has guessed
        if (Input.GetKeyDown(KeyCode.Return))
        {
            enterKeyPressed = true;
        }

        // Check if the cursor object is found
        if (cursorObject != null)
        {
            // Retrieve the cursor object's position and save it as a Vector3
            cursorPosition = cursorObject.transform.position;

            // Check if the cursor position exists as a key in the dictionary
            foreach (var entry in countryLocationDictionary)
            {
                // Compare the cursor position with each key using a tolerance level
                if (Vector3.Distance(entry.Key, cursorPosition) < positionTolerance)
                {
                    // Get the corresponding values for the cursor position
                    List<string> countries = entry.Value;

                    // Concatenate the country names into a single string
                    string allCountries = string.Join(", ", countries);

                    // If they guess a tile
                    if (enterKeyPressed == true)
                    {
                        // if they are correct
                        if (countries.Contains(countryValueLowercase))
                        {
                            correctGuess = true;
                            enterKeyPressed = false;
                        }
                        // if they are not correct
                        else
                        {
                            correctGuess = false;
                            enterKeyPressed = false;
                        }
                    }

                    // Break the loop since we found a match
                    break;
                }
            }
        }
    }
}
