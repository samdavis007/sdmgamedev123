using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sumof4num : MonoBehaviour
{
   public int a,b,c,d,resultorg,sum,result;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            sum =a+b;
            Debug.Log("sum="+sum);
        }
           
        if(Input.GetKeyDown(KeyCode.B))
        { 
            sum =sum+c;
            Debug.Log("sum="+sum);
        }
        
        if(Input.GetKeyDown(KeyCode.C))
        {
            result=sum+d;
            Debug.Log("result="+result);
        }  
        if(Input.GetKeyDown(KeyCode.D))
        {
            resultorg=result+d;
            Debug.Log("result="+result);
        }

    }   
         
         
}

