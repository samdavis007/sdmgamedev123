using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements.Experimental;

public class armstrong : MonoBehaviour
{
    
    public int originalNum,remainder,result=0,num;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
          originalNum = num;

        while (originalNum != 0) {
       // remainder contains the last digit
        remainder = originalNum % 10;
        
       result += remainder * remainder * remainder;
        
       // removing last digit from the orignal number
       originalNum /= 10;
    }

    if (result == num)
    {
       Debug.Log(" is an Armstrong number.");
    }
    else
    {
       Debug.Log(" is not an Armstrong number.");
    }
       
    }
}
}
    
    

    
