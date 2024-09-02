using UnityEngine;
using TMPro;

public class PatternNo13 : MonoBehaviour
{
    public TextMeshProUGUI star;
    public int i;
    public int j; 
    public int n; 
    private string s;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            

            for ( i = 0; i < n; i++)
            {
                for ( j = 0; j < n; j++)
                {
                    
                     if (i == 0 || j == 0 || i == n - 1|| j == n - 1 &&i >= (n / 2) || i== (n / 2) && j>=n/2 )
                    {
                        s += " *";
                    }
                    else
                    {
                        s += "   ";
                    }
                }
                s += "\n";
            }
            star.text = s;
        }
    }
}