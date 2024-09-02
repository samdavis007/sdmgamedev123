using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MultiplySignPattern : MonoBehaviour
{
    public TextMeshProUGUI star; 
    private string a;           
    public int n = 5;            

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
           

            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j || i + j == n - 1)
                    {
                        a += " * ";
                    }
                    else
                    {
                        a += " - ";
                    }
                }
                a += "\n";
            }

            star.text = a; 
        }
    }
}
