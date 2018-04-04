using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public CharacterController charController;

    public float walkSpeed;

    void Awake()
    {
        charController = GetComponent<CharacterController>();
    }
    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        float horiz = Input.GetAxis("Horizontal");
        float vert = Input.GetAxis("Vertical");


    }
}
