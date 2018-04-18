using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockAController : MonoBehaviour
{
    public float speed =  0.3f;
    public float jumpForce = 15.0f;
    public float rotSpeed = 10.0f;
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

        float playerLook = transform.localEulerAngles.x + mouseY * rotSpeed / Time.deltaTime;
        playerLook = Mathf.Clamp(playerLook,-90,90);
        transform.localEulerAngles = new Vector3(playerLook,
                                                0.0f,
                                                0.0f);

        blockA.transform.localEulerAngles = new Vector3(0.0f,
                                                        blockA.transform.localEulerAngles.y + mouseX * rotSpeed / Time.deltaTime,
                                                        0.0f);

        playerMove = blockA.transform.position;
        playerMove.x += Input.GetAxis("Horizontal") * speed / Time.deltaTime;
        playerMove.z += Input.GetAxis("Vertical") * speed / Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerMove.y = jumpForce;
            Debug.Log("JUMP!!");
        }

        blockA.transform.position = playerMove;
    }
}

