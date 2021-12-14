using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindObject : MonoBehaviour
{
    Rigidbody rb;
    GameObject ob;
    GameObject[] obs;
    // Start is called before the first frame update
    void Start()
    {
        // Find game object "Cube", get access to the rigid body component and change
           // GameObject.Find ("Cube2").GetComponent<Rigidbody>().useGravity = true;
           // Game0bject.Find ("Cube2").GetComponent<Rigidbody>().mass = 5;

        rb = GameObject.Find("Cube2").GetComponent<Rigidbody>();
        rb.useGravity = true;
        rb.mass = 5;

        // Find game object with Tag "Hide" and by using function SetActive - hide it from scene
           //GameObject.FindWithTag("Hide").SetActive(false);

        ob = GameObject.FindWithTag("Hide");
        ob.SetActive(false);

        // Find game objects with Tag "Destroy" and by using function foreach and Destroy - destroy them from the scene
        obs = GameObject.FindGameObjectsWithTag("Destroy");
        foreach(GameObject oo in obs)
        {
          Destroy(oo);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
