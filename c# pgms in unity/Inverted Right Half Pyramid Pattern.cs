using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InvertedRightHalfPyramid : MonoBehaviour
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
                for (int j = 1; j <= i; j++)
                {
                    a += "*";
                }
                a += "\n";
            }

            star.text = a;
        }
    }
}
