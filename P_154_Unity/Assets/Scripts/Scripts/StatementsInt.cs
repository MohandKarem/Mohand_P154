using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatementsInt : MonoBehaviour
{
    public int score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (score == 0)
        {
            print("FAILED!");
        }

        else if (0 < score && score < 50)
        {
            print("FAILED!");
        } 

        else if (score == 50)
        {
            print("PASSED");
        } 

        else if (50 < score && score < 60)
        {
            print("PASSED");
        }

        else if (score == 60)
        {
            print("PASSED WELL");
        }

        else if (60 < score && score < 75)
        {
            print("PASSED WELL");
        }

        else if (score == 75)
        {
            print("PASSED GOOD");
        }

        else if (75 < score && score < 100)
        {
            print("PASSED GOOD");
        }

        else if (score == 100)
        {
            print("PASSED GREAT!");
        }

        else
        {
            print("TRY AGAIN");
        }
    }
}
