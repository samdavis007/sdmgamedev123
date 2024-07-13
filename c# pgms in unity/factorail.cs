using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class factorial : MonoBehaviour
{
    public int i,num;
    public int fact=1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if(Input.GetKeyDown(KeyCode.A)){
        for(i=num;i>=1;i--)
        {
            fact=fact*i;
            Debug.Log(i);
        }
        Debug.Log(fact);
        fact=1;
        

      }
    }
}
