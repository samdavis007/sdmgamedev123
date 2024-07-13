using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class palindrome : MonoBehaviour
{
    public int orginal,rem,reversed=0,num;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         if(Input.GetKeyDown(KeyCode.A))
         {
            orginal=num;
            //// reversed integer is stored in reversed variable
            while(num!=0) 
            {
              rem=num %10;                                                            
              reversed=reversed*10+rem;
              num=num/10;                                                       
            }
            // palindrome if orignal and reversed are equal
            if(orginal==reversed)
            {
                Debug.Log("palindrome");
                orginal=0;
                reversed=0;
            }
            else
            {
                Debug.Log("not palindrome");
                orginal=0;
                reversed=0;
            }
            
         }
    }
}
