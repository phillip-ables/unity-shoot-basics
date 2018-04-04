using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour {

    //new class scope variable, public so we can interact directly in the inspector
    //controls the speed at which we rotate when we move the mouse
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

        //extract the current rotation of the game object
        Vector3 targetRot = transform.rotation.eulerAngles;
        targetRot.x -= rotAmountX;
        targetRot.y += rotAmountY;
        //transform.rotation is a quaternion and we use Euler angles to tranform it with vectors
        transform.rotation = Quaternion.Euler(targetRot);
    }
}
