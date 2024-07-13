using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oddoreven1 : MonoBehaviour
{
    
    public int n;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A))
        {

        
        if(n%2!=0)
        {
           Debug.Log("odd number");
        }
        else
        {
            Debug.Log("even number");
        }
        
    }
    }
    
}
