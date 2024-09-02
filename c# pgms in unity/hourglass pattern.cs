using UnityEngine;
using TMPro;

public class HourglassPattern : MonoBehaviour
{
    public TextMeshProUGUI star;
    public int n;
    private string s;

    void Start()
    {
       
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            

           
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    s += " ";
                }
                for (int j = 0; j < n - i; j++)
                {
                    s += "* ";
                }
                s += "\n";
            }

           
            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    s += " ";
                }
                for (int j = 0; j <= i; j++)
                {
                    s += "* ";
                }
                s += "\n";
            }

            star.text = s;
        }
    }
}
