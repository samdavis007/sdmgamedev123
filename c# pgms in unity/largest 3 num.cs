using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class largest3num  : MonoBehaviour
{
    public int a;
    public int b;
    public int c;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            if(a>b&&a>c)
            {
                Debug.Log("a is great");
            }
            
        else if(b>c)
        {
            Debug.Log("b is great");
        }
        else
        {
            Debug.Log("c is great");
        }
        }

    }
}
