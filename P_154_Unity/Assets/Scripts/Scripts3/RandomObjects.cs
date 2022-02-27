using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomObjects : MonoBehaviour
{
    public GameObject[] objects;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
        int randnumb = Random.Range(0, objects.Length);
        Instantiate(objects[randnumb], transform.position, Quaternion.identity);
        }
    }
}
