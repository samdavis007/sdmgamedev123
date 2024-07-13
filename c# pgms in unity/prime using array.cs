using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class primeusingarray : MonoBehaviour
{
     int limit = 100;  // Change this limit to whatever range you want

    // Start is called before the first frame update
    void Start()
    {
        
   
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            bool[] isPrime = new bool[limit + 1];

        // Assume all numbers are prime initially
        for (int i = 2; i <= limit; i++)
        {
            isPrime[i] = true;
        }

        // Mark non-prime numbers
        for (int i = 2; i <= limit; i++)
        {
            if (isPrime[i])
            {
                for (int j = i * 2; j <= limit; j += i)
                {
                    isPrime[j] = false;
                }
            }
        }

        // Print all prime numbers
        Debug.Log("Prime numbers up to " + limit + ":");
        for (int i = 2; i <= limit; i++)
        {
            if (isPrime[i])
            {
                Debug.Log(i);
            }
        }
    }
    }
}