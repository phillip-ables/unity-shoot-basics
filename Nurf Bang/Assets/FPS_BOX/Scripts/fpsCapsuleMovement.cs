using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fpsCapsuleMovement : MonoBehaviour {
    public float walkAcceleration = 5.0f;
    public GameObject cameraObject;

    private void Update()
    {
        transform.rotation = Quaternion.Euler(0, cameraObject.GetComponent<fpsLook>().currentYRotation, 0);
        gameObject.GetComponent<Rigidbody>().AddRelativeForce(Input.GetAxis("Horizontal") * walkAcceleration, 0, Input.GetAxis("Vertical") * walkAcceleration);
    }
}
