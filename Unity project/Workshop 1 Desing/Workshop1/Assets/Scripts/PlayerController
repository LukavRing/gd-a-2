using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;

    private float horizontalInput;
    private float verticalInput;

    public float speed;

    // Jumping
    public float jumpHeight;
    private bool isJumpPressed = false;
    private bool isGrounded = true;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        // movement
        Vector3 movement = new Vector3(horizontalInput, 0.0f, verticalInput);
        rb.AddForce(movement * speed);

        // jumping
        if (isJumpPressed && isGrounded)
        {
            rb.AddForce(transform.up * jumpHeight, ForceMode.Impulse);
            isJumpPressed = false;
            isGrounded = false;
        }
    }

    void OnJump()
    {
        if (isGrounded) isJumpPressed = true;
    }

    private void OnCollisionEnter(Collision collision)
    {
        isGrounded = true;
    }

    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();
        horizontalInput = movementVector.x;
        verticalInput = movementVector.y;
    }
}
