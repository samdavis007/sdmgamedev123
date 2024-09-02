using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Pluspattern : MonoBehaviour
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
            

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == n / 2 || j == n / 2)
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
