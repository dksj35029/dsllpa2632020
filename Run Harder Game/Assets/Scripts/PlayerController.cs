﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

	public float speed = 5f;
	public float jumpSpeed = 8f;
	private float movement = 0f;
	private Rigidbody2D rigidBody;
    public Transform groundCheckPoint;
    public float groundCheckRadius;
    public LayerMask groundLayer;
    private bool isTouchingGround;


    // Start is called before the first frame update
    void Start()
    {
    	rigidBody = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        isTouchingGround = Physics2D.OverlapCircle(groundCheckPoint.position, groundCheckRadius, groundLayer);
    	movement = Input.GetAxis("Horizontal");

    	if(movement > 0f) //moving right
    	{
    		rigidBody.velocity = new Vector2(movement*speed,rigidBody.velocity.y);
    	}

    	else if(movement < 0f) //moving left
    	{
    		rigidBody.velocity = new Vector2(movement*speed,rigidBody.velocity.y);
    	}

    	else //prevent ball from rolling when no keys pushed
    	{
    		rigidBody.velocity = new Vector2(0,rigidBody.velocity.y);
    	}

    	if(Input.GetButtonDown("Jump") && isTouchingGround) //if space is pressed (to jump), and the player is on the ground
    	{
    		rigidBody.velocity = new Vector2(rigidBody.velocity.x,jumpSpeed);

    	}

        
    }
}
