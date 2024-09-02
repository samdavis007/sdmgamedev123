using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InvertedFullPyramid : MonoBehaviour
{
    public TextMeshProUGUI star;
    private string a;
    public int n;

    void Start()
    {
       
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            

            for (int i = n; i >= 1; i--)
            {
                for (int j = 0; j < n - i; j++)
                {
                    a += " ";
                }
                for (int j = 0; j < 2 * i - 1; j++)
                {
                    a += "*";
                }
                a += "\n";
            }

            star.text = a;
        }
    }
}
