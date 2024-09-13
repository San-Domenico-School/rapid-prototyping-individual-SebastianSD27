using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

/*******************************************
 * Component of the Vheicle, takes in user 
 * input to move and turn the vehicle
 * 
 * Sebastian Balakier
 * September 11, 2024 Version 1.0
*******************************************/

public class PlayerController : MonoBehaviour
{
    private float speed;                    // holds the forward movement of the vehicle
    private float turnspeed;                // holds the turn speed of the vehicle
    private float verticalInput;            // gets a value [-1, 1] from user key press up/down or W/S
    private float horizontalInput;          // gets a value [-1, 1] from user key press left/right or A/D

    private Rigidbody rb;                   // points to vehicle rigidbody component

    // Initiallizes speed before the first frame update
    void Start()
    {
        speed = 40.0f;
        turnspeed = 45.0f;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float mass = rb.mass;
        rb.AddRelativeForce(Vector3.forward * mass * speed * verticalInput);
        transform.Rotate(Vector3.up * turnspeed * horizontalInput * Time.deltaTime);
    }

    // Called from PlayerActionInput when user presses WASD or arrow keys
    private void OnMove(InputValue inputValue)
    {
        verticalInput = inputValue.Get<Vector2>().y;
        horizontalInput = inputValue.Get<Vector2>().x;
    }



}