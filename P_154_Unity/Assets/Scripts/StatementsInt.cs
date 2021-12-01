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
        if (score > 60)
        {
            print("PASSED");
        }

        if (60 < score && score < 75)
        {
            print("PASSED WELL");
        }

        if (75 < score && score < 100)
        {
            print("PASSED GOOD");
        }

        if (score == 100)
        {
            print("PASSED GREAT!");
        }

        else
        {
            print("TRY AGAIN");
        }
    }
}
