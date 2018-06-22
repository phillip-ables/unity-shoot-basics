using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fpsCapsuleMovement : MonoBehaviour {
    public float walkAcceleration = 5.0f;
    public GameObject cameraObject;
    public float maxWalkSpeed = 50.0f;

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
        velocity = new Vector3(horizontalMovement.x, 0, horizontalMovement.y);
        rb.velocity = velocity;

        transform.rotation = Quaternion.Euler(0, cameraObject.GetComponent<fpsLook>().currentYRotation, 0);
        rb.AddRelativeForce(Input.GetAxis("Horizontal") * walkAcceleration, 0, Input.GetAxis("Vertical") * walkAcceleration);
    }
}
