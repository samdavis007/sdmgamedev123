using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class usingarrayarmstrong : MonoBehaviour
{
    int rem;
    int result;
    int s;
    public int[] num;
    public int value;
    int n;
    // Start is called before the first frame update
    void Start()
    {
        num=new int[n];
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            s=value;
            while(s!=0)
            {
                rem=s%10;
                result=result+rem*rem*rem;
                s=s/10;
            }
            if(result == value)
            {
                num[0]=result;
                Debug.Log("its an armstrong");
            }
            else
            {
                num[0]=result;
                Debug.Log("not armstrong");
            }
        }
    }
}
