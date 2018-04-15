using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HunchController : MonoBehaviour {
    public float speed = 20.0f;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        float translation = Input.GetAxis("Horizontal") * speed;
        float straffe = Input.GetAxis("Vertical") * speed;
        translation *= Time.deltaTime;
        straffe *= Time.deltaTime;

        transform.Translate(straffe, 0, -translation);

        if (Input.GetKeyDown("escape"))
            Cursor.lockState = CursorLockMode.None;
        
    }
}
