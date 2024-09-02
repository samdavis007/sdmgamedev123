using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class largestof3nosifaandbisequal : MonoBehaviour
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
        if(Input.GetKeyUp(KeyCode.A))
        {
            if(a>b)
            {
                if(a>c)
                {
                    Debug.Log ("a is great");
                
                }
                else if(a==c)
                {
                    Debug.Log ("a and c is equal");
                }
                else
                {
                    Debug.Log("c is great");
                }
            }
                else if(a==b)
                {
                    Debug.Log("a and b is equal");
                }
                else if(b>c)
                {
                    Debug.Log("b is great");
                }
                else if(b==c)
                {
                    Debug.Log("print b and c");
                }
                else
                {
                    Debug.Log("c is great");
                }
            
        }
    }
}
