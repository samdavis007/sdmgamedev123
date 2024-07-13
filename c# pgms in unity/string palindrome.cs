using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stringpalindrome : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            string str = "malayalam"; // Example string to check
        
        if(IsPalindrome(str))
        {
            Debug.Log("{str} is a palindrome.");
        }
        else
        {
            Debug.Log("{str} is not a palindrome.");
        }
    }
    
     static bool IsPalindrome(string str)
    {
        for(int i = 0; i < str.Length / 2; i++)
        {
            if(str[i] != str[str.Length - 1 - i])
            {
                return false;
            }
        }
        return true;
    }
}
    
}
        