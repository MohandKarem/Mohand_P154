using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transformations : MonoBehaviour
{
    public float speed = 0.01f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += new Vector3(0, 0.01f, 0); // transform.position = transform.position + new Vector3(0, 0.01f, 0);
        }

    // Transform position of Game Object to the left by defining function "transform.right" and by left arrow
    // keyboard button

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += -transform.right*speed; // transform.position = transform.position + new Vector3(0, 0.01f, 0);
        }
    // Move Game Object to the right by defining function "transform.Translate" and by right arrow keyboard button
        {
       if (Input.GetKey(KeyCode.RightArrow))
        {       
            transform.Translate(speed,0,0); // transform.position = transform.position + new Vector3(0, 0.01f, 0);
        }
    // Rotate the Game Object by "transform.Rotate" and change it scale by "transform.localScale" and defining new
    // Vector3 and by down arrow keyboard button
       if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Rotate(speed, 0, speed); // transform.position
            transform.localScale += new Vector3(0, speed, 0);
        }
    }    
}
}