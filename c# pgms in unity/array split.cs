using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arraysplit : MonoBehaviour
{
    [SerializeField] private int[] originalArray = { 1, 2, 3, 4, 5, 6, 7, 8 };
    [SerializeField] private int[] firstHalf;
    [SerializeField] private int[] secondHalf;
    [SerializeField] private int[] firstQuarter;
    [SerializeField] private int[] secondQuarter;
    [SerializeField] private int[] thirdQuarter;
    [SerializeField] private int[] fourthQuarter;

    void Start()
    {
        SplitArray();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            DebugArray("First Half: ", firstHalf);
            DebugArray("Second Half: ", secondHalf);
        }
          if (Input.GetKeyDown(KeyCode.Return))
        {
            DebugArray("First Quarter: ", firstQuarter);
            DebugArray("Second Quarter: ", secondQuarter);
            DebugArray("Third Quarter: ", thirdQuarter);
            DebugArray("Fourth Quarter: ", fourthQuarter);
        }
    }

    void SplitArray()
    {
        int mid = originalArray.Length / 2;

        firstHalf = new int[mid];
        secondHalf = new int[mid];

        for (int i = 0; i < mid; i++)
        {
            firstHalf[i] = originalArray[i];
            secondHalf[i] = originalArray[mid + i];
        }

        SplitFurther(firstHalf, out firstQuarter, out secondQuarter);
        SplitFurther(secondHalf, out thirdQuarter, out fourthQuarter);
    }

        void SplitFurther(int[] array, out int[] firstPart, out int[] secondPart)
    {
        int mid = array.Length / 2;
        firstPart = new int[mid];
        secondPart = new int[mid];

        for (int i = 0; i < mid; i++)
        {
            firstPart[i] = array[i];
            secondPart[i] = array[mid + i];
        }
    }

    void DebugArray(string message, int[] array)
    {
        string arrayContent = message;
        foreach (int element in array)
        {
            arrayContent += element + " ";
        }
        Debug.Log(arrayContent);
    }
}