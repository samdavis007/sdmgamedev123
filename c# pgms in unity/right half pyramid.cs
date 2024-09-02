using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class righthalfpyramid : MonoBehaviour
{
    public int rows = 5; 
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
            

           
            for (int i = 0; i < rows; i++)
            {
              
                for (int j = 0; j <= i; j++)
                {
                    text += "*";
                }
                text += "\n"; 
            }

            pattern.text = text;
        }
    }
}
