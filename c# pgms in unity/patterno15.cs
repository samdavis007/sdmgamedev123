using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CustomPattern : MonoBehaviour
{
    public TextMeshProUGUI pattern;
    private string text;
    public int n = 8; // Setting the value of N

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Top half pattern
            for (int i = 0; i <= n / 2; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j <= i)
                    {
                        text += " * ";
                    }
                    else if (i == n / 2 && j < n)
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

            // Bottom half pattern
            for (int i = 0; i < n / 2; i++)
            {
                for (int k = 0; k <= n / 2 + i; k++)
                {
                    text += " - ";
                }
                for (int j = n / 2 + 1 + i; j < n; j++)
                {
                    text += " * ";
                }
                text += "\n";
            }

            pattern.text = text;
        }
    }
}
