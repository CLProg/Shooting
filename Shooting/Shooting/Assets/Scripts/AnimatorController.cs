using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimControl : MonoBehaviour
{
    // Variables to hold horizontal and vertical input values
    float horizontal;
    float vertical;

    // Animator variable
    Animator animator;

    // Boolean variable to test if facing right
    bool facingRight = true; // Default to facing right

    void Awake()
    {
        // Link the GameObject's Animator component to the animator variable
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Check if the user is pressing Horizontal input
        horizontal = Input.GetAxis("Horizontal");
        // Check if the user is pressing Vertical input
        vertical = Input.GetAxis("Vertical");

        // Set the Speed parameter in the animator component
        animator.SetFloat("Speed", Mathf.Abs(horizontal) + Mathf.Abs(vertical));

        // Check if the fire button is pressed
        if (Input.GetButtonDown("Fire1")) // "Fire1" is typically set to left mouse button or Ctrl
        {
            Shoot();
        }
    }

    void FixedUpdate()
    {
        // Function for changing the character facing direction
        Flip(horizontal);
    }

    private void Flip(float horizontal)
    {
        // Check where the character is currently facing and adjust the graphics direction
        if (horizontal < 0 && facingRight || horizontal > 0 && !facingRight)
        {
            facingRight = !facingRight;

            Vector3 scale = transform.localScale;
            scale.x *= -1; // Flip the character's x scale
            transform.localScale = scale; // Update the local scale
        }
    }

    private void Shoot()
    {
        // Trigger the shooting animation
        animator.SetTrigger("Shoot");

        // Add your shooting logic here (e.g., instantiating bullets)
        Debug.Log("Shoot!");
    }
}
