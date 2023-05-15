using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float moveSpeed = 50f; // The movement speed of the object
    private Rigidbody rb; // The Rigidbody component of the object
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();   
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal"); // Get the horizontal input from the keyboard
        float vertical = Input.GetAxis("Vertical"); // Get the vertical input from the keyboard

        Vector3 movement = new Vector3(horizontal, 0f, vertical); // Create a movement vector from the input

        rb.AddForce(movement * moveSpeed); // Move the object by adding force to its Rigidbody component
    }
}
