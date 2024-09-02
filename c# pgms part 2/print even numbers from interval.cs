using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class printevennumbersfrominterval : MonoBehaviour
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
        
        for(int i=1;i<=n;i++){
           
            if(i%2==0)
            {
                  Debug.Log(i);   
            }
            

    }
}
}
