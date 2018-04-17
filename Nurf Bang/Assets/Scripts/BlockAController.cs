using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockAController : MonoBehaviour
{
    public float speed = 15.0f;
    public float jumpForce = 15.0f;
    public float rotSpeed = 20.0f;
    Vector3 playerMove;
    GameObject blockA;

    private void Start()
    {
        transform.rotation = Quaternion.Euler(0, 0, 0);
        blockA = this.transform.parent.gameObject;
    }

    private void Update()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        transform.localEulerAngles = new Vector3(transform.localEulerAngles.x + mouseY * rotSpeed,
                                                transform.localEulerAngles.y + mouseX * rotSpeed,
                                                0.0f);

        playerMove = blockA.transform.position;
        playerMove.x += Input.GetAxis("Horizontal") * speed;
        playerMove.z += Input.GetAxis("Vertical") * speed;

        if (Input.GetKeyDown(KeyCode.Space) && playerMove.y < jumpForce)
        {
            playerMove.y = jumpForce;
            Debug.Log("JUMP!!");
        }

        blockA.transform.position = playerMove;
    }
}

