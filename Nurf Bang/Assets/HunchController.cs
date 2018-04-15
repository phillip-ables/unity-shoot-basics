using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HunchController : MonoBehaviour {
    public float speed = 220.0f;
    public float jumpForce = 15.0f;

    private Rigidbody rbHunch;
    private Vector3 velHunch;
    private float horVel;
    private float verVel;



    private void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked;
        rbHunch = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetKeyDown("escape"))
            Cursor.lockState = CursorLockMode.None;
        
    }

    private void LateUpdate()
    {
        velHunch = rbHunch.velocity;
        velHunch.x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        velHunch.z = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        if (Input.GetButtonDown("Jump") && rbHunch.position.y < 1)
        {
            Debug.Log("Jump");
            velHunch.y = jumpForce;
        }
        rbHunch.velocity = velHunch;
    }
}
