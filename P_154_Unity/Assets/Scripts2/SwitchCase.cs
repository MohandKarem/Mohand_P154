using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCase : MonoBehaviour
{
    public int control;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (control)
        {
             case 1:
                 GameObject.Find("Cylinder" ).GetComponent<Renderer>().material.color = Color.red;
                 //GetComponent<Renderer>().material.color = Color.red;
                 break;
       
             case 2:
                 GameObject.Find("Cylinder").GetComponent<Renderer>().material.color = Color.yellow;
                 //GetComponent<Renderer>().material.color = Color.yellow;
                 break;

             case 3:
                 GetComponent<Renderer>().material.color = Color.blue;
                 break;
 
             default:
                 GetComponent<Renderer>().material.color = Color.green;
                 break;
        }
    }
}
