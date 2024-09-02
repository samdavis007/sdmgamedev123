using UnityEngine;
using TMPro;

public class Diamondhollow : MonoBehaviour
{
    public TextMeshProUGUI star;
    private string s;
    public int n;

    void Start()
    {
       
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i + j == n / 2 || i - j == n/2 || i + j == n / 2 * 3 || j - i == n / 2 )
                    {
                        s += " * ";
                    }
                    else
                    {
                        s += " - ";
                    }
                }
                s += "\n";
            }
            star.text = s;
        }
    }
}
