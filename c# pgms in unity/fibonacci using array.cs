using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fibonacciusingarray : MonoBehaviour
{
    int a=0;
    int b=1;
    int c=0;
    public int []num;
    public int n;
    int j=0;
    // Start is called before the first frame update

    void Start()
    {
        num = new int[n];
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            for (int i = 1; i <= n; i++)
            {
                num[j]=a;
                c=a+b;
                Debug.Log(a);
                a=b;
                b=c;
                j++;
            }
        }
    }
}
