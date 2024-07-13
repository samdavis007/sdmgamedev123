using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reverse : MonoBehaviour
{
    
    
   
public int num,rem,result=0;    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
        while(num!=0)
        {
        rem=num%10;
        result=result*10+rem;
        num=num/10;
        }
        Debug.Log(result);
       
    }
    }
}
