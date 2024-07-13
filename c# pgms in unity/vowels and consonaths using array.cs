using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vowelsandconsonathsusingarray : MonoBehaviour
{
    
    int[]inputstring;
    int i, len, vowels, consonants;
     
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
   
    int[]inputstring  = {'s','a','m','d','a','v','i','s'};      
    vowels = 0;
    consonants = 0;
    len = inputstring.Length;
 
    // Iterating the string from left to right
    if(Input.GetKeyDown(KeyCode.A))
    {
          for(i = 0; i < len; i++)
    {
         
        // Check if the character is a vowel
        if (inputstring[i] == 'a' || inputstring[i] == 'e' || inputstring[i] == 'i' || inputstring[i] == 'o' || inputstring[i] == 'u' || inputstring[i] == 'A' || inputstring[i] == 'E' || inputstring[i] == 'I' || inputstring[i] == 'O' || inputstring[i] == 'U')
        {
             
        // Increment the vowels
            vowels++;
        }
         
        // Check if the character is a alphabet
        // other than vowels
        else if ((inputstring[i] >= 'a' && inputstring[i] <= 'z') || 
                 (inputstring[i] >= 'A' && inputstring[i] <= 'Z'))
        {
             
            // Increment the consonants
            consonants++;
        }
    }
     
    // Display the count of vowels and consonant
    Debug.Log("count of vowel = " + vowels);
    Debug.Log("count of consonant = " + consonants);
}
}
    


    }
    