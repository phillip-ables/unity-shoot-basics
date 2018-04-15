using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMouseMove : MonoBehaviour {
    private float rotHead;
    private float rotBody;
    private Vector3 charachterRot;
    public float turnSpeed = 10.0f;

    private void Start()
    {
    }
    private void Update()
    {
        float mouseX = Input.GetAxis("MouseX");
        float mouseY = Input.GetAxis("MouseY");

    }
}
