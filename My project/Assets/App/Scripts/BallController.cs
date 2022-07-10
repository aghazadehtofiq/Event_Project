using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
	public float ballSpeed;
	public Rigidbody ballRb;

	private float horizontalInput;
	private float verticalInput;

	void Awake()
    {
		ballRb = GetComponent<Rigidbody>();
    }
	
	private void FixedUpdate()
	{
		ProcessInputs();
		Move();
	}

	/*private void OnTriggerEnter(Collider collision)
	{
		if (collision.gameObject.gameObject.layer == LayerMask.GetMask("Ground"))
		{
			isOnGround = true;
		}
	}*/

	private void ProcessInputs()
    {
		horizontalInput = Input.GetAxis("Horizontal");
		verticalInput= Input.GetAxis("Vertical");
	}

	private void Move()
    {
		ballRb.AddForce(new Vector3(horizontalInput, 0f, verticalInput) * ballSpeed);
    }
}