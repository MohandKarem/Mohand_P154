using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatementsString : MonoBehaviour
{
    public string name;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (name == "Khaled")
        {
            print("YOU ARE Khaled!");
        }
        else
        {
            print("YOU ARE NOT Khaled!");
        }    
    }
}
