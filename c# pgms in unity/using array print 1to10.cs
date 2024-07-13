using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class usingarrayprint1to10 : MonoBehaviour
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
            Debug.Log(" print 1 to 10 numbers");
            for(int i=0;i<numbers.Length;i++)
            {
                Debug.Log(numbers[i]);
            }
            
        }
    }
}
