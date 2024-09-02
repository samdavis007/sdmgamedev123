using UnityEngine;
public class ticketbooking : MonoBehaviour
{
    private int[] seats = {1,2,3,4,5,6,7,8,9,10};
    public int book;
    public int cancel;
    public bool[] tickets;
    public float timer = 60;
    public int winner;
    public int[] winnerstore;
    public int[] selectionStore;
    int s = 0;
    int a;
    int temp = 0;
    int k;
    // Start is called before the first frame update
    void Start()
    {
        tickets = new bool[11];
        winnerstore = new int[11];
        
       
    }

    // Update is called once per frame
    void Update()
    {
        if(timer>=0)
        {
            timer = timer - Time.deltaTime;
        }
       
        if (timer>10 && timer<60)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                for (int i = 0; i < seats.Length; i++)
                {
                    if (book == seats[i])
                    {
                        if (tickets[i + 1] == true)
                        {
                            print(i + 1 + " already booked");
                            book = 0;
                        }
                        if (tickets[i + 1] == false)
                        {
                            tickets[i + 1] = true;
                            winnerstore[s] = i + 1;
                            s++;
                            Debug.Log(i + 1 + " is booked");
                            book = 0;


                        }



                    }
                    if (cancel == seats[i])
                    {
                        tickets[i + 1] = false;
                        for(int j=0; j<winnerstore.Length; j++)
                        {
                            if(winnerstore[j] == i+1)
                            {
                                winnerstore[j] = 0;
                                if (winnerstore[j+1]==0)
                                {
                                    s--;
                                }
                                else
                                {
                                    for(int k=j; k<winnerstore.Length-1; k++)
                                    {
                                        winnerstore[k] = winnerstore[k+1];

                                    }
                                    s--;
                                }
                                
                            }

                        }
                        
                        print(i + 1 + " is cancelled");
                        cancel = 0;
                    }


                }
               



            }

        }
        if (timer > 0 && timer < 10 && temp == 0)
        {
            
            for (int i = 0; i < winnerstore.Length; i++)
            {
                if (winnerstore[i] != 0)
                {
                    a++;
                }
            }

            selectionStore = new int[a];
            for (int i = 0; i < winnerstore.Length; i++)
            {
                if (winnerstore[i] != 0)
                {
                    selectionStore[k] = winnerstore[i];
                    k++;
                }
            }
            
            winner = Random.Range(0, a-1);
            temp++;
            print(selectionStore[winner] + " is winner");



        }
        
    }
}