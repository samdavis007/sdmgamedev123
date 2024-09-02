using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HollowSquarePattern : MonoBehaviour
{
    public int size; 
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
           

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                
                    if (i == 0 || i == size - 1 || j == 0 || j == size - 1)
                    {
                        text += " * ";
                    }
                    else
                    {
                        text += " - "; 
                    }
                }
                text += "\n"; 
            }

            pattern.text = text;
        }
    }
}
