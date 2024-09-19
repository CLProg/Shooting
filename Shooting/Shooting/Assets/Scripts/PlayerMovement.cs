using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    // Variable used to set the movement speed of the player
    public float runSpeed = 5f; // Changed to float for smoother movement
    // Variable used to hold the horizontal value
    float horizontal;
    // Variable used to hold the vertical value
    float vertical;

    void Update()
    {
        // Check if the user is pressing Horizontal inputs
        horizontal = Input.GetAxis("Horizontal");
        // Check if the user is pressing Vertical inputs
        vertical = Input.GetAxis("Vertical");
    }

    void FixedUpdate()
    {
        // Set the value vector movement of the player depending on the user input
        Vector3 movement = new Vector3(horizontal * runSpeed, 0.0f, vertical * runSpeed);
        // Move the player to the set vector location according to the movement value
        transform.position += movement * Time.deltaTime; // Simplified assignment
    }
}
