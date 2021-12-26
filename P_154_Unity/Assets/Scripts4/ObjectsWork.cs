using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsWork : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vehicle myVehicle = new Vehicle();
        myVehicle.speed = 5.5f;
        myVehicle.color = "Red";

        Vehicle newVehicle = new Vehicle();
        newVehicle.speed = 10f;
        newVehicle.color = "White";

        myVehicle.VehicleSpeed();
        myVehicle.VehicleColor();

        newVehicle.VehicleSpeed();
        newVehicle.VehicleColor();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
