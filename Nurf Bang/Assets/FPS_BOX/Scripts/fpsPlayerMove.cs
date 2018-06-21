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
        if (Input.GetAxis("Horizontal") > 0)
        {
            Camera.main.transform.position += Vector3.right * moveSpeed;
            Debug.Log("Right");
        }
        if (Input.GetAxis("Horizontal") < 0)
        {
            Camera.main.transform.position += Vector3.left * moveSpeed;
            Debug.Log("Left");
        }
    }

}
