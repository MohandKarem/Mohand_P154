using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForeachLoop : MonoBehaviour
{
    public GameObject[] go;
    // Start is called before the first frame update
    void Start()
    {
        // Destroy gameobjects in corresponding array with "foreach" function
        foreach(GameObject storego in go)
        {
            Destroy(storego);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
