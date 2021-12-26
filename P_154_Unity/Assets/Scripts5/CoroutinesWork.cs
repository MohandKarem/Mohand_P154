using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutinesWork : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartCoroutine("Test");
        }        
    }

    IEnumerator Test()
    {
        print ("coroutine started");
        yield return new WaitForSeconds(2f);
        GetComponent<Renderer>().material.color = Color.red;
        yield return new WaitForSeconds(3f);
        GetComponent<Renderer>().material.color = Color.green;
        print ("coroutine ended");
    }
}
