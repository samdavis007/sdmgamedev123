using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class primeornot : MonoBehaviour
{
    public int i,num,temp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            for(int i=1;i<=num;i++)
            {
                if(num%i==0)
                {
                    temp++;
                }
               

            }
             if(temp==2)
                {
                    Debug.Log(num +"prime number");
                    temp=0;
                }
                else
                {
                    Debug.Log(num+"not prime");
                    temp=0;
                }
        }
    }
}
