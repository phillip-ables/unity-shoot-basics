using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fpsCapsuleMovement : MonoBehaviour {
    public float walkAcceleration = 5.0f;
    public GameObject cameraObject;
    public float maxWalkSpeed = 50.0f;

    private Rigidbody rb;
    private Vector2 horizontalMovement;

    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    private void Update()
    {
        horizontalMovement = new Vector2(rb.velocity.x, rb.velocity.z);

        transform.rotation = Quaternion.Euler(0, cameraObject.GetComponent<fpsLook>().currentYRotation, 0);
        rb.AddRelativeForce(Input.GetAxis("Horizontal") * walkAcceleration, 0, Input.GetAxis("Vertical") * walkAcceleration);
    }
}
