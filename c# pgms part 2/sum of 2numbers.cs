using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sumof2numbers : MonoBehaviour
{
    public int a;
    public int b;
    int sum;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyUp(KeyCode.A))
       {
           sum=a+b; 
           Debug.Log(sum);
       }
    }
       
}

