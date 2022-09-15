using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    private Renderer render;

    // Movement
    public float speed;
    private float horizontalMovement;
    private float verticalMovement;

    // Jumping
    public float jumpHeight;
    private bool isJumpPressed = false;
    private bool isGrounded = true;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        render = rb.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        // movement
        Vector3 movement = new Vector3(horizontalMovement, 0.0f, verticalMovement);
        rb.AddForce(movement * speed);

        // jumping
        if (isJumpPressed && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpHeight, ForceMode.Impulse);
            isJumpPressed = false;
            isGrounded = false;
        }
    }

    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();
        horizontalMovement = movementVector.x;
        verticalMovement = movementVector.y;
    }

    void OnJump()
    {
        if (isGrounded) isJumpPressed = true;
    }

    private void OnCollisionEnter(Collision collider)
    {
        isGrounded = true;

        Material hitMaterial = collider.transform.GetComponent<Renderer>().material;
        render.material = hitMaterial;
    }
}
