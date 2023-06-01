using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public float moveSpeed = 5f; // Movement speed of the character

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // Read the horizontal and vertical input axis
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        // Calculate the movement vector
        Vector2 movement = new Vector2(moveX, moveY) * moveSpeed;

        // Apply the movement to the rigidbody
        rb.velocity = movement;
    }
}
