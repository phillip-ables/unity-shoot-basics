using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fpsCapsuleMovement : MonoBehaviour {
    public float walkAcceleration = 5.0f;
    public float walkDeacceleration = 5.0f;
    public GameObject cameraObject;
    public float maxWalkSpeed = 50.0f;
    public float jumpVelocity = 800.0f;
    public float maxSlope = 60.0f;

    private bool grounded = false;
    private Rigidbody rb;
    private Vector2 horizontalMovement;
    private Vector3 velocity;

    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    private void Update()
    {
        horizontalMovement = new Vector2(rb.velocity.x, rb.velocity.z);
        if(horizontalMovement.magnitude > maxWalkSpeed)
        {
            horizontalMovement.Normalize();
            horizontalMovement *= maxWalkSpeed;
        }

        if (Input.GetAxis("Horizontal") == 0
            && Input.GetAxis("Vertical") == 0
            && grounded)
        {
            horizontalMovement.x /= walkDeacceleration;
            horizontalMovement.y /= walkDeacceleration;
        }

        velocity = new Vector3(horizontalMovement.x, 0, horizontalMovement.y);
        rb.velocity = velocity;

        transform.rotation = Quaternion.Euler(0, cameraObject.GetComponent<fpsLook>().currentYRotation, 0);
        rb.AddRelativeForce(Input.GetAxis("Horizontal") * walkAcceleration, 0, Input.GetAxis("Vertical") * walkAcceleration);

        if(Input.GetButtonDown("Jump") && grounded)
        {
            rb.AddForce(0, jumpVelocity, 0);
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        foreach(ContactPoint contact in collision.contacts)
        {
            if(Vector3.Angle(contact.normal, Vector3.up) < maxSlope)
            {
                grounded = true;
            }
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        grounded = false;
    }
}
