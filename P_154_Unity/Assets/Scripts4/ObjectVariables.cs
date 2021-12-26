using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectVariables : MonoBehaviour
{
    public Vehicle myVehicle;
    // Start is called before the first frame update
    void Start()
    {
        myVehicle.PrintParams();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
