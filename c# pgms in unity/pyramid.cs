using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class pyramid : MonoBehaviour
{
    public TextMeshProUGUI star;
    public int n;
    private string a;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            
            for(int i = 1; i <= n; i++)
            {
                for(int j = 0; j < i; j++)
                {
                    a += " * ";
                }
                a += "\n";
            }
            star.text = a;
        }
    }
}
