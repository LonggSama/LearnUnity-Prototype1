using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    // Public Variables
    [SerializeField] Rigidbody playerRb;
    [SerializeField] float horsePower;
    [SerializeField] GameObject player;
    [SerializeField] GameObject centerOfMass;
    [SerializeField] TextMeshProUGUI speedometerText;
    [SerializeField] TextMeshProUGUI rpmText;
    [SerializeField] List<WheelCollider> allWheels;

    public float turnSpeed = 10.0f;

    private float vehicleSpeed;
    private float horizontalInput;
    private float forwardInput;

    private void Awake()
    {
        playerRb = GetComponent<Rigidbody>();
        playerRb.centerOfMass = centerOfMass.transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // This is where we get player input
        if (player.CompareTag("Player"))
        {
            forwardInput = Input.GetAxis("Vertical");
            horizontalInput = Input.GetAxis("Horizontal");
        }
        else if (player.CompareTag("Player1")){
            forwardInput = Input.GetAxis("Vertical1");
            horizontalInput = Input.GetAxis("Horizontal1");
        }
        else if(player.CompareTag("Player2"))
        {
            forwardInput = Input.GetAxis("Vertical2");
            horizontalInput = Input.GetAxis("Horizontal2");
        }



        if (IsOnGround())
        {
            // Move the car forward based on vertical input
            // player.transform.Translate(Vector3.forward * Time.deltaTime * vehicleSpeed * forwardInput);
            playerRb.AddRelativeForce(Vector3.forward * horsePower * forwardInput);
            vehicleSpeed = Mathf.RoundToInt(playerRb.velocity.magnitude * 3.6f);
            // Rotates the car based on horizontal input
            player.transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * turnSpeed * horizontalInput);
        }
        else
            vehicleSpeed = 0;

        speedometerText.SetText("Speed: " + vehicleSpeed + " KM/H");
        rpmText.SetText("RPM: " + ((vehicleSpeed % 30) * 40));
    }

    bool IsOnGround()
    {
        int wheelOnGround = 0;
        foreach (WheelCollider wheel in allWheels)
        {
            if (wheel.isGrounded)
            {
                wheelOnGround++;
            }
        }
        if (wheelOnGround > 0)
        {
            return true;
        }
        else { return false; }
    }
}
