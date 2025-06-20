using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    [SerializeField] private float speed;
    [SerializeField] private float jumpForce;
    private bool isGrounded;
    public GameObject groundPlane; 
    private Rigidbody rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += speed * Vector3.forward * Time.deltaTime; // Moves up (world space)
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += speed * Vector3.left * Time.deltaTime; // Moves left (world space)
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += speed * Vector3.back * Time.deltaTime; // Moves down (world space)
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += speed * Vector3.right * Time.deltaTime; // Moves right (world space)
        }

        if (isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        
        }
    }
    void Jump()
    {
        // Apply an upward impulse to make the player jump
        rb.AddForce(Vector3.up * jumpForce, ForceMode.VelocityChange);
    }

    // Set isGrounded to true when colliding with the specified groundPlane
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == groundPlane)
        {
            isGrounded = true;
        }
    }

    // Set isGrounded to false when leaving collision with the specified groundPlane
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject == groundPlane)
        {
            isGrounded = false;
        }
    }
}

