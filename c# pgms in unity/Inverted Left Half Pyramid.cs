using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InvertedLeftHalfPyramid : MonoBehaviour
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
           

            for (int i = 0; i < n; i++)
            {
                 for (int j = 0; j < 2 * i; j++)
                {
                    a += " ";
                }
                 for (int k = 0; k < n- i; k++)
                {
                    a += "*";
                }
                a += "\n";
            }

            star.text = a;
        }
    }
}
