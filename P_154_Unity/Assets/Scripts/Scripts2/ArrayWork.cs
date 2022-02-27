using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayWork : MonoBehaviour
{
   // create arrays type of: int, string, gameobject, color with the array size of 3
       public int[] numbers;
       public string[] names;
       public GameObject[] gameobjects;
       public Color[] colors;

    // Start is called before the first frame update
    void Start()
    {
       // print variables: int with index 2, string with index 0 in Start()
       print(numbers[2]);
       print(names[0]);

       gameobjects[1].GetComponent<Renderer>().material.color=colors[2];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
