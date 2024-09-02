using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class usingarrayprintevenandodd : MonoBehaviour
{
    public int[]numbers=new int[10];
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.A))
        {
            for (int i=0;i<numbers.Length;i++)
            {
                numbers[i]=i+1;
            }
           for(int i=0;i<numbers.Length;i++)
           {
            if(numbers[i]%2==0)
            {
                Debug.Log(numbers[i]+ "print even");
            }
            else
            {
                Debug.Log(numbers[i]+"print odd");
            }
           }
        }
    }
}
    
    
