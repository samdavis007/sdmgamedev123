using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
   
   public int a;

    // Start is called before the first frame update
    void Start()
    {
      
    
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftAlt))
       {
         Debug.Log(a);
       }
    }
}
