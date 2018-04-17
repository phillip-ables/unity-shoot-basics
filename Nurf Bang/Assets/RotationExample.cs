using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationExample : MonoBehaviour {
    public float speed = 15.0f;

    private void Start()
    {
        transform.rotation = Quaternion.Euler(0, 0, 0);
    }

    private void Update()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        transform.localEulerAngles = new Vector3(transform.localEulerAngles.x + mouseY,
                                                transform.localEulerAngles.y + mouseX,
                                                0.0f);

        transform.position = new Vector3(Input.GetAxis("horizontal") * speed,
                                        0.0f,
                                        Input.GetAxis("vertical") * speed);
    }
}
