using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallsPlayer : MonoBehaviour {
    //Variables
    public float movementSpeed;
    public int rotSpeed = 7;

    //Methods
    private void Update()
    {
        //camera position
        Plane playerPlane = new Plane(Vector3.up, transform.position);
        //mouse location
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        float hitDist = 0.0f;

        if(playerPlane.Raycast(ray, out hitDist))
        {
            Vector3 targetPoint = ray.GetPoint(hitDist);
            Quaternion targetRotation = Quaternion.LookRotation(targetPoint - transform.position);
            targetRotation.x = 0;
            targetRotation.z = 0;
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotSpeed * Time.deltatime);
        }

    }

}
