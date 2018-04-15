using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HunchController : MonoBehaviour {
    public float moveSpeed = 5.0f;
    public float turnSpeed = 20.0f;
    public float jumpForce = 18.0f;

    private float horizontalInput;
    private float verticalInput;
    private float mouseX;
    private float mouseY;
    private Vector3 velHunch;
    private Rigidbody rbHunch;
    //Transform transCam;

    private void Start()
    {
        rbHunch = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        mouseX = Input.GetAxis("Mouse X");
        mouseY = Input.GetAxis("Mouse Y");

        velHunch = rbHunch.velocity;
        velHunch.x = horizontalInput * moveSpeed * Time.deltaTime;
        velHunch.y = verticalInput * moveSpeed * Time.deltaTime;

        if (Input.GetButtonDown("space"))
            velHunch.z = jumpForce;

        if (Input.GetButtonDown("escape"))
            Cursor.lockState = CursorLockMode.None;
    }

    private void LateUpdate()
    {
        rbHunch.velocity = velHunch;
    }
}
