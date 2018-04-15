using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HunchController : MonoBehaviour {
    public float speed = 270.0f;
    public float jumpForce = 8.0f;
    private Rigidbody rbHunch;
    private Vector3 velHunch;
    private float horVel;
    private float verVel;

    public float sensitivity = 5.0f;
    public float smoothing = 2.0f;
    public Transform headHunch;
    private Vector2 mouseLook;
    private Vector2 smoothV;

    private void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked;
        rbHunch = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetKeyDown("escape"))
            Cursor.lockState = CursorLockMode.None;
        
    }

    private void LateUpdate()
    {
        //move head parent with camera child
        var md = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));

        md = Vector2.Scale(md, new Vector2(sensitivity * smoothing, sensitivity * smoothing));
        smoothV.x = Mathf.Lerp(smoothV.x, md.x, 1f / smoothing);
        smoothV.y = Mathf.Lerp(smoothV.y, md.y, 1f / smoothing);
        mouseLook += smoothV;
        mouseLook.y = Mathf.Clamp(mouseLook.y, -90f, 90f);


        //move position of hunch empty rigid
        velHunch = rbHunch.velocity;
        velHunch.x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        velHunch.z = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        if (Input.GetButtonDown("Jump") && rbHunch.position.y < 1)
            velHunch.y = jumpForce;
        
        rbHunch.velocity = velHunch;
    }
}
