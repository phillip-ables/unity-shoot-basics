using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallsPlayer : MonoBehaviour {
    //Variables
    public float movementSpeed;
    public int rotSpeed = 7;
    public float waitTime = 0.5f;

    public GameObject bulletSpawnPoint;
    public GameObject playerObject;
    public GameObject bullet;

    //Methods
    private void Update()
    {

        //PLAYER FACING MOUSE!!//
        Plane playerPlane = new Plane(Vector3.up, transform.position);  // cameraPosition
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);  // mouseLocation
        float hitDist = 0.0f;

        if(playerPlane.Raycast(ray, out hitDist))
        {
            Vector3 targetPoint = ray.GetPoint(hitDist);
            Quaternion targetRotation = Quaternion.LookRotation(targetPoint - transform.position);
            targetRotation.x = 0;
            targetRotation.z = 0;
            playerObject.transform.rotation = Quaternion.Slerp(playerObject.transform.rotation, targetRotation, rotSpeed * Time.deltaTime);
        }

        //PLAYER MOVEMENT!!//
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * movementSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * movementSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * movementSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * movementSpeed * Time.deltaTime);
        }

        //SHOOTING!!//
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        Debug.Log("BANG!!");
    }

}
