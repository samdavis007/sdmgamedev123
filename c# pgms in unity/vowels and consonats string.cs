using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vowelsandconsonatsstring : MonoBehaviour
{
    string input = "Hello Unity!";  // Change this to any input string
    int vowelCount = 0;
    int consonantCount = 0;
    // Define vowels
    string vowels = "aeiou";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         // Convert the string to lowercase for easier comparison
        input = input.ToLower();
        if(Input.GetKeyDown(KeyCode.A))
        {
        // Count vowels and consonants
        foreach (char c in input)
        {
            if (char.IsLetter(c))
            {
                if (vowels.Contains(c))
                {
                    vowelCount++;
                }
                else
                {
                    consonantCount++;
                }
            }
        }
         // Print the counts
        Debug.Log("Vowels: " + vowelCount);
        Debug.Log("Consonants: " + consonantCount);
        }
    }
}