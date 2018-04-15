using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HunchController : MonoBehaviour {
    public float moveSpeed = 5.0f;
    public float turnSpeed = 20.0f;
    public float jumpForce = 18.0f;

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
        rbHunch.transform.position += Vector3.forward;
    }
}
