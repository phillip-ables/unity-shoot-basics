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
                    hitInfo.rigidbody.AddForceAtPosition(rayOrigin.direction, hitInfo.point);
                }
            }
        }
    }
}
