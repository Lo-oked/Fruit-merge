using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Top : MonoBehaviour
{
    public GameObject line;
    public float timeRemaining = 3;
    public float secondtimeRemaining = 5;
    bool i;
    bool b;
    static bool T;


    void Update()
    {
        if (i && timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }
        else if (b && secondtimeRemaining > 0)
        {
            secondtimeRemaining -= Time.deltaTime;
        }
    }



    void OnTriggerEnter2D(Collider2D collision)
    {
        i = true;
        if (timeRemaining < 0)
        {
            b = true;
            line.SetActive(true);

            if (secondtimeRemaining < 0)
            {
                T = true;
            }
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        i = false;
        b = false;
        timeRemaining = 3;
        secondtimeRemaining = 5;
        line.SetActive(false);
    }

    

}
