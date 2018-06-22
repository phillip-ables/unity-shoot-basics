using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayRaycast : MonoBehaviour {
    public float rayRange = 25.0f;
    public float hitPower = 500.0f;

    private void Update()
    {
        //if left mouse button is clicked
        //create a raycast that originates from the mouse click position
        if (Input.GetMouseButtonDown(0))
        {
            Ray rayOrigin = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;

            if (Physics.Raycast(rayOrigin, out hitInfo, rayRange))
            {
                Debug.DrawLine(rayOrigin.direction, hitInfo.point);

                if (hitInfo.rigidbody != null)
                {
                    //call the hit information
                    //call the rigid body
                    // call the addforceposition menu
                    //call the direction fo the hit information
                    //call the position of where the force should be
                    //add with the direction, your force variable
                    hitInfo.rigidbody.AddForceAtPosition(rayOrigin.direction * hitPower, hitInfo.point);

                    //call the hit information.
                    //call the transform
                    //gameobject
                    //renderer
                    //material
                    //color
                    // = new color.
                }
            }
        }
    }
}
