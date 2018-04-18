using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadMouseMove : MonoBehaviour
{
    Vector2 mouseLook;
    Vector2 smoothV;
    public float sensitivity = 5.0f;
    public float smoothing = 2.0f;

    GameObject charHump;
    Rigidbody rbHunch;

    private void Start()
    {
        charHump = this.transform.parent.gameObject;

    }

    private void Update()
    {
        // raw data
        var md = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));

        //scaled up
        md = Vector2.Scale(md, new Vector2(sensitivity * smoothing, sensitivity * smoothing));
        smoothV.x = Mathf.Lerp(smoothV.x, md.x, 1f / smoothing);
        smoothV.y = Mathf.Lerp(smoothV.y, md.y, 1f / smoothing);
        mouseLook = smoothV;

        //clampedZA
        mouseLook.y = Mathf.Clamp(mouseLook.y, -90f, 90f);



        //transform.rotation  *= Quaternion.Euler(new Vector3(0,0,-mouseLook.y));
        //transform.eulerAngles = new Vector3(-mouseLook.y, 0f, 0f);
        charHump.transform.localRotation = Quaternion.AngleAxis(mouseLook.x, charHump.transform.up);
    }
}