using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SolidRectanglePattern : MonoBehaviour
{
    public TextMeshProUGUI star; 
    private string a;           
    public int m = 4;           
    public int n = 5;          

    void Start()
    {
    
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
           

            
            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    a += "*"; 
                }
                a += "\n"; 
            }

            star.text = a;
        }
    }
}
