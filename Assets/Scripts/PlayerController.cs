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
    [SerializeField] GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
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


        // Move the car forward based on vertical input
        player.transform.Translate(Vector3.forward * Time.deltaTime * vehicleSpeed * forwardInput);
        // Rotates the car based on horizontal input
        player.transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * turnSpeed * horizontalInput);
    }
}
