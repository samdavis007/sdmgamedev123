using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stringmanipulation : MonoBehaviour
{
        string str = "Hello, World!";
        string substr = "World";
        string addition = " How are you?";
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
         if(Input.GetKeyDown(KeyCode.A))
         {
          
        // Search for the substring
        if (str.Contains(substr))
        {
            Debug.Log("Substring found: " + substr);

            // Concatenate the additional string
            str += addition;
            Debug.Log("String after addition: " + str);
        }
        else
        {
            Debug.Log("Substring not found");
        }
    }
}
}