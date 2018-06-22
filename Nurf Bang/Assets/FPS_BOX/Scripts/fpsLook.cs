using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fpsLook : MonoBehaviour {
    //Variables
    public float lookSensitivity = 5.0f;
    public float yRotation;
    public float xRotation;
    public float currentYRotation;
    public float currentXRotation;
    public float yRotationVelocity;
    public float xRotationVelocity;
    public float lookSmoothDamp = 0.1f;

    //Methods
    private void Update()
    {
        yRotation += Input.GetAxis("Mouse X") * lookSensitivity;
        xRotation -= Input.GetAxis("Mouse Y") * lookSensitivity;

        currentXRotation = Mathf.SmoothDamp(currentXRotation, xRotation, ref xRotationVelocity, lookSmoothDamp);
        currentYRotation = Mathf.SmoothDamp(currentYRotation, yRotation, ref yRotationVelocity, lookSmoothDamp);

        transform.rotation = Quaternion.Euler(currentXRotation, currentYRotation, 0);
    }
}
