using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class printnprimenumbers : MonoBehaviour
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
               for (int i=2; i<=num; i++)
            {
                int temp=0;

                for (int j=2; j<=i/2; j++)
                {
                    if (i % j == 0)
                    {
                        temp++;
                        break;
                    }
                }

                if (temp == 0 && i != 1)
                {
                    Debug.Log(i);
                }
            }

            Debug.Log(num);
        }    
         }
        
    }

