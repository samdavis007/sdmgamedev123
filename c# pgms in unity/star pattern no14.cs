using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class TriangleCombined : MonoBehaviour
{
    public TextMeshProUGUI pattern;
    private string star;
    int i;
    int j;
    public int n;
    int a;
    int b;

    // Start is called before the first frame update
    void Start()
    {
        a = n / 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            

            
            for (i = a; i >= 0; i--)
            {
                for (j = 0; j < i; j++)
                {
                    star += " ";
                }
                for (j = 0; j < n - 2 * i; j++)
                {
                    star += "*";
                }
                star += "\n";
            }

            
            for (i = a - 1; i >= 0; i--)
            {
                for (j = 0; j < i; j++)
                {
                    star += " ";
                }
                if (i == a - 1)
                {
                    
                    star += "*";
                }
                else if (i == a - 2)
                {
                
                    star += "***";
                }
                else
                {
                    for (j = 0; j < n - 2 * i; j++)
                    {
                        star += "*";
                    }
                }
                star += "\n";
            }

            pattern.text = star;
        }
    }
}
