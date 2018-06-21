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
		
	}
}
