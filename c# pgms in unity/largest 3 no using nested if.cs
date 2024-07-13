using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class largest3nousingnestedif : MonoBehaviour
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
            if(a>b)
            {

            

            if(a>c)
            {
                Debug.Log("a is greater");
            }
            else
            {
                Debug.Log("c is greater");
            }
            }
            else if(b>c)
            {
                Debug.Log("b is greater");
            }
            else
            {
                Debug.Log("c is greater");
            }
        }    

        
        

    }
}
