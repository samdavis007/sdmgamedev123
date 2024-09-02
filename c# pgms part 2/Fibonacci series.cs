using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fibonacciseries : MonoBehaviour
{
    
    public int a=0,b=1,c=0,n;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        for(int i=0;i<n;i++)
        {
            c=a+b;
            Debug.Log(a);
            a=b;
            b=c;
        }
    }
}
