 using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class diamondPattern : MonoBehaviour
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
            

            int mid = n / 2;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if ((i < mid && (j >= mid - i && j <= mid + i)) || 
                        (i >= mid && (j >= i - mid && j <= 3 * mid - i)))
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
