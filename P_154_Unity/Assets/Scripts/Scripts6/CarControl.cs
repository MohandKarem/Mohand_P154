using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarControl : MonoBehaviour
{
    public float maxSpeed = 30;     // public max speed identfication
    public Rigidbody RB;            // RigitBody Identfication to use the Gravity
    float speedInput;               // To identitfy the speed input to our script
    float turnStrength = 180f;      // To identitfy the wheels turn strenght
    float turnInput;                // To identitfy the turning input to our scriot
    public float forwardAccel = 10f, reverseAccel = 5f;     // To identitfy the forward and reverse Accel in the script to times it later in the script to make numbers minuim.
    public Transform leftFrontWheel, rightFrontWheel;       // To identitfy the Front left and front right wheels and allowiong it for movments using Transform.
    public float maxWheelTurn = 25f;   // to set a maximum turning angel for the wheels
    
    // Start is called before the first frame update
    void start()
    {
        RB.transform.parent = null;  // To make the transforamtion of the wheels outside the car model
    }

    // Update is called once per frame
    // We made it Fixed
    void FixedUpdate()
    {
        speedInput = 0f;   // we identified the speed input.
        if(Input.GetAxis("Vertical") > 0)  // this if function to get the moving forward input from unity play inputs   // > 0 means pressing W keyboard key in my situation.
        {
            speedInput = Input.GetAxis("Vertical") * forwardAccel; // (0...1)*forwardAccel   // this will make the object move forward with the speed identified time the number in public speed forward accel
        }
        if(Input.GetAxis("Vertical") < 0)  // this if function to get the reverse input from unity play inputs   // < 0 means pressing s keyboard key in my situation.
        {
            speedInput = Input.GetAxis("Vertical") * reverseAccel; // (0...1)*forwardAccel    // this will make the object move reverse with the speed identified time the number in public speed reverse accel
        }
     

        turnInput = Input.GetAxis("Horizontal");   // we identified the Horizontal input to use it to turn the object.
        if (Input.GetAxis("Vertical") != 0)    // this if function to get the turning input from unity play inputs   // ! = 0 means pressing a/d keyboard keys in my situation.
     
        {
            // this line to transform object as the speed and angel of rotation by the delta time 
            transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(0, turnInput * turnStrength * Time.deltaTime * Mathf.Sign(speedInput) * (RB.velocity.magnitude/maxSpeed) * 0.3f, 0));
        }
            // this line is to transform the object wheel, so we can see the wheels movments to right as we turn right
        leftFrontWheel.localRotation=Quaternion.Euler(leftFrontWheel.localRotation.eulerAngles.x, (turnInput * maxWheelTurn), leftFrontWheel.localRotation.eulerAngles.z);
            // this line is to transform the object wheel, so we can see the wheels movments to left as we turn left
        rightFrontWheel.localRotation=Quaternion.Euler(rightFrontWheel.localRotation.eulerAngles.x, (turnInput * maxWheelTurn), rightFrontWheel.localRotation.eulerAngles.z);
            //  here we set the force of the moving forward time the speed input and times 1000f
        RB.AddForce(transform.forward * speedInput * 10f);   
        transform.position = RB.position;  
            //  this to change the velocity if the speed equal to max
        if (RB.velocity.magnitude > maxSpeed)
        {
            // this for make the function work of the last ling
            RB.velocity = RB.velocity.normalized * maxSpeed; // 0...55 -> (0...1) * maxSpeed -> 0...30
        }
            // this to print the volocity during the playing of the project so we can check if it's wordking.
        print(RB.velocity.magnitude);
    }
}
