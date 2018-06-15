using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    CharacterController charController;

    public float walkSpeed;

    //which layers we want to look out for:
    public LayerMask groundLayers;
    public float jumpForce = 799;  // how high we want to jump
    public Rigidbody rb;

    #region Monobehaviour API

    void Awake()
    {
        charController = GetComponent<CharacterController>();
        rb = GetComponent<Rigidbody>();
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


        //jump code
        //when we hit space add force
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Jump");
            rb.AddForce(Vector3.up*jumpForce, ForceMode.Impulse);  // ForceMode.Impulse is very important or else you wont see much happen
        };
    }
    #endregion
}
