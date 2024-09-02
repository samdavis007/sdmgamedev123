using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class factorailusingarray : MonoBehaviour
{
    int limit = 10;  
        
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        long[] factorials = new long[limit + 1];

        
        factorials[0] = 1;
        if(Input.GetKeyDown(KeyCode.A))
        {
       
        for (int i = 1; i <= limit; i++)
        {
            factorials[i] = factorials[i - 1] * i;
        }

        
        Debug.Log("Factorials up to " + limit + ":");
        for (int i = 0; i <= limit; i++)
        {
            Debug.Log(i + "! = " + factorials[i]);
        }
    }
}
}
    