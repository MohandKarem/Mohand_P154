using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunctionsWork : MonoBehaviour
{
    int val = 7;
    // Start is called before the first frame update
    void Start()
    {
        int newval = doublelevel();
        print(newval);

        int newsum = sumval(5);
        print(newsum);
    }

    // Update is called once per frame
    void Update()
    {

    }

    int doublelevel()
    {
        return (val * 2);

    }

    int sumval(int variable)
    {
        return (variable + 10);
    }
}
