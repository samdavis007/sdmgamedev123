using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StarPattern5x5 : MonoBehaviour
{
    public TextMeshProUGUI star;
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
           

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    a += " *";
                }
                a += "\n";
            }

            star.text = a;
        }
    }
}
