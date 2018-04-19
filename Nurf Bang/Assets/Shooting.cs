using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {
    public GameObject bullet;
    public GameObject bulletSpawn;
    public float fireRate;


	void Start () {
		
	}
	
	void Update ()
    {
        if (Input.GetMouseButton(0))// left mouse button
        {
            Fire();
        }		
	}

    public void Fire()
    {

    }
}
