using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LeftHalfPyramid : MonoBehaviour
{
    public int n; 
    public TextMeshProUGUI pattern;
    private string text;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            

            for (int i = 1; i <= n; i++)
            {
                
                for (int j = 1; j <= n - i; j++)
                {
                    text += " - "; 
                }

                // Stars
                for (int j = 1; j <= i; j++)
                {
                    text += " * ";
                }

                text += "\n";
            }

            pattern.text = text;
        }
    }
}
