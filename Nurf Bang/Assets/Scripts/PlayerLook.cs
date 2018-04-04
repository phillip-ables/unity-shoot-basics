using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour {
    public Transform playerBody;
    //new class scope variable, public so we can interact directly in the inspector
    public float mouseSensitivity;


    //lock the mouse cursor to the center of the screen so that it cannot move
    void Awake()//only called once for each game object
    {
        Cursor.lockState = CursorLockMode.Locked;
    }


    void Update()
    {
        RotateCamera();
    }

    void RotateCamera()
    {
        //declare two variables
        float MouseX = Input.GetAxis("Mouse X");
        float MouseY = Input.GetAxis("Mouse Y");

        //mouseSensitivity as a multiplier
        float rotAmountY = MouseX * mouseSensitivity;
        float rotAmountX = MouseY * mouseSensitivity;

        Vector3 targetRotCam = transform.rotation.eulerAngles;
        Vector3 targetRotBody = playerBody.rotation.eulerAngles;

        targetRotCam.x -= rotAmountX;
        targetRotBody.y += rotAmountY;
        //transform.rotation is a quaternion and we use Euler angles to tranform it with vectors
        transform.rotation = Quaternion.Euler(targetRotCam);
        playerBody.rotation = Quaternion.Euler(targetRotBody);
    }
}
