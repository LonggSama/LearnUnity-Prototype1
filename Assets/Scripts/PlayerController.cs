using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Public Variables
    public float vehicleSpeed = 20f;
    public float turnSpeed = 10.0f;
    private float horizontalInput;
    private float forwardInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // This is where we get player input
        forwardInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        // Move the car forward based on vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * vehicleSpeed * forwardInput);
        // Rotates the car based on horizontal input
        transform.Rotate(Vector3.up,turnSpeed * Time.deltaTime * turnSpeed * horizontalInput);
    }
}
