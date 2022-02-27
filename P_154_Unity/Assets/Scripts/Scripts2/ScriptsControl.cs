using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptsControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //GetComponent<ColorControl>().score=90;
        GameObject.Find ("Cube2").GetComponent<ColorControl>().score = 90;
        GameObject.Find ("Cube2").GetComponent<Renderer>().material.color = Color.blue;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
