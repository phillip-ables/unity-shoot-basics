using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fpsPlayerMove : MonoBehaviour {
    public GameObject player;
    public float turnSpeed;
    public float moveSpeed;
    public float jumpStrength;
    public bool isRunning;
    public bool isAiming;


    private void Update()
    {
        //PLAYER MOVEMENT!!//
        if (Input.GetAxis("Horizontal") > 0)
        {
            Camera.main.transform.position += Vector3.right * moveSpeed * Time.deltaTime;
        }
        if (Input.GetAxis("Horizontal") < 0)
        {
            Camera.main.transform.position += Vector3.left * moveSpeed * Time.deltaTime;
        }
        if (Input.GetAxis("Vertical") > 0)
        {
            Camera.main.transform.position += Vector3.forward * moveSpeed * Time.deltaTime;
        }
        if(Input.GetAxis("Vertical") < 0)
        {
            Camera.main.transform.position += Vector3.back * moveSpeed * Time.deltaTime;
        }


    }

}
