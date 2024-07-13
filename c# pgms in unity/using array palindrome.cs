using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class usingarraypalindrome : MonoBehaviour
{
    private int rem,reversed=0,num;
    public int n;
    public int orginal;
    public int []numbers;

    // Start is called before the first frame update
    void Start()
    {
        numbers = new int[n];
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            num = orginal;
            
                while(num !=0)
                {
                    rem=num%10;
                    reversed=reversed*10+rem;
                    num=num/10;
                }
                if(orginal==reversed)
                {
                    Debug.Log( numbers[num] + "is palindrome");
                }
                else
                {
                   Debug.Log(numbers[num]+"is not palindrome");
                }
            }
        }
    }   
