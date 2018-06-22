using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fpsLook : MonoBehaviour {
    //Variables
    public float lookSensitivity = 5.0f;
    public float lookSmoothDamp = 0.1f;

    private float yRotation;
    private float xRotation;
    private float currentYRotation;
    private float currentXRotation;
    private float yRotationVelocity;
    private float xRotationVelocity;

    //Methods
    private void Update()
    {
        yRotation += Input.GetAxis("Mouse X") * lookSensitivity;
        xRotation -= Input.GetAxis("Mouse Y") * lookSensitivity;

        xRotation = Mathf.Clamp(xRotation, 90, -90);

        currentXRotation = Mathf.SmoothDamp(currentXRotation, xRotation, ref xRotationVelocity, lookSmoothDamp);
        currentYRotation = Mathf.SmoothDamp(currentYRotation, yRotation, ref yRotationVelocity, lookSmoothDamp);

        transform.rotation = Quaternion.Euler(currentXRotation, currentYRotation, 0);
    }
}
