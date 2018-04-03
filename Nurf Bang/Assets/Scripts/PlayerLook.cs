using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour {

    //new class scope variable, public so we can interact directly in the inspector
    //controls the speed at which we rotate when we move the mouse
    public float mouseSensitivity;

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
        float rotAmountX = MouseX * mouseSensitivity;
        float rotAmountY = MouseY * mouseSensitivity;

    }
}
