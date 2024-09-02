using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vowelsandconsonatsstring : MonoBehaviour
{
    string input = "Hello Unity!";  
    int vowelCount = 0;
    int consonantCount = 0;
    
    string vowels = "aeiou";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         
        input = input.ToLower();
        if(Input.GetKeyDown(KeyCode.A))
        {
        
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
         
        Debug.Log("Vowels: " + vowelCount);
        Debug.Log("Consonants: " + consonantCount);
        }
    }
}