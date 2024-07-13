using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class largest2num : MonoBehaviour
{
    public int a;
    public int b;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A))
        {
            if(a>b)
            {
                Debug.Log("a is largest ");
        
            }
            else
            {
                Debug.Log("b is largest");
            }
        }
    }
}
