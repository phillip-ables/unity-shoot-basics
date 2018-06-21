using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fpsRayViewer : MonoBehaviour {
    //Variables
    public float weaponRange = 50f;

    private Camera fpsCam;

    //Mehtods
	void Start () {
        fpsCam = GetComponentInParent<Camera>();
	}
	
	void Update () {
        Vector3 lineOrgin = fpsCam.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0));
        Debug.DrawRay(lineOrgin, fpsCam.transform.forward * weaponRange, Color.green);
    }
}
