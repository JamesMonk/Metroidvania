using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    // Necessary for animations and physics
    private Rigidbody2D rb2D;
    private Animator myAnimator; // 1, -1, 0

    // Variable to play with
    public float speed = 2.0f;
    public float horizMovement;

    private void Start()
    {
        // Define the game ojects found on the player
        rb2D = GetComponent<Rigidbody2D>();
        myAnimator = GetComponent<Animator>();
    }

    // Handles the input for the physics
    private void Update()
    {
        // Check direction given by the player
        horizMovement = Input.GetAxisRaw("Horizontal");
    }

    // Handles running the physics
    private void FixedUpdate() 
    {
        // Move the character left and right
        rb2D.velocity = new Vector2(horizMovement*speed, rb2D.velocity.y);
    }
}
