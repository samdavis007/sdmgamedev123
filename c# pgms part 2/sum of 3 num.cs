using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sumof3num : MonoBehaviour
{
   
   public int a;
   public int b;
   public int c;
   int sum;
   int result;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftAlt))
        {
            sum = a+b;
            Debug.Log("sum="+sum);
        
            result=sum+c;
            Debug.Log("result="+result);
        }
    }
}
