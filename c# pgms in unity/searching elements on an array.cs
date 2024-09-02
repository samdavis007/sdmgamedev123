using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class searchingelementsonanarray : MonoBehaviour
{
public int[] numbers = {};
public int target = 10;
bool found = false;
// Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    if(Input.GetKeyDown(KeyCode.A))
    {
    for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] == target)
    {
        found = true;
        break;
    }
}
if (found)
{
    Debug.Log("After Searching Element found.");
}
else
{
    Debug.Log("After Searching Element not found.");
}
}

}
}
