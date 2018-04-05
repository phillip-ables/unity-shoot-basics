﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    CharacterController charController;

    public float walkSpeed;

    //which layers we want to look out for:
    public LayerMask groundLayers;
    public float jumpForce = 7;  // how high we want to jump
    public CapsuleCollider col;


    void Awake()
    {
        charController = GetComponent<CharacterController>();
        col = GetComponent<CapsuleCollider>();
    }
    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        float horiz = Input.GetAxis("Horizontal");
        float vert = Input.GetAxis("Vertical");

        Vector3 moveDirSide = transform.right * horiz * walkSpeed;
        Vector3 moveDirForward = transform.forward * vert * walkSpeed;

        charController.SimpleMove(moveDirForward);
        charController.SimpleMove(moveDirSide);
    }
}
