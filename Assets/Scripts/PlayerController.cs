using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float moveSpeed;
    public float jumpForce;

    private Rigidbody2D rigidbody;

    public bool grounded;
    public LayerMask whatIsGround;

    private Collider2D collider;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        collider = GetComponent<Collider2D>();
    }


    void Update()
    {
        Move();
    }

    private void Move()
    {
        grounded = Physics2D.IsTouchingLayers(collider, whatIsGround);

        rigidbody.velocity = new Vector2(moveSpeed, rigidbody.velocity.y);

        if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            if (grounded)
            {
                rigidbody.velocity = new Vector2(rigidbody.velocity.x, jumpForce);
            }
        }
    }
}
