using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class invertedtriangle : MonoBehaviour
{
    public int height; 
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
             

            for (int i = 0; i < height; i++)
            {
                
                text += new string(' ', i);

                
                for (int j = 0; j < height - i; j++)
                {
                    text += "* ";
                }

                text += "\n";
            }

            pattern.text = text;
        }
    }
}
