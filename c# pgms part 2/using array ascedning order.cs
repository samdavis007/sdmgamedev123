using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class usingarrayascedningorder : MonoBehaviour
{
    public int[]arr;
    int i,j,temp;
    
    // Start is called before the first frame update
    void Start()
    {
        arr=new int[5];
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            for(i=0;i<5;i++)
            {
             Debug.Log(arr[i]);
            }
            for(i=0;i<5;i++)
            {
                for(j=i+1;j<5;j++)
                {
                    if(arr[i]>arr[j])
                    {
                        temp=arr[i];
                        arr[i]=arr[j];
                        arr[j]=temp;
                    }
                }
                
            }

            for(i=0;i<5;i++)
        {
            Debug.Log(arr[i]);
        }
    }
    }
}
           
        
        

