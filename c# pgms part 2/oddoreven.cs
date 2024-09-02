using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oddoreven : MonoBehaviour
{
    public int n;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            if(n%2==0)
            {
                Debug.Log("even");
            }
            else
            {
                Debug.Log("odd");
            }        
        }

    }
}
