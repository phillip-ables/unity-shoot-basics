using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fpsRaycastShoot : MonoBehaviour {
    //Variables
    public int gunDamage = 1;
    public float fireRate = .25f;
    public float weaponRange = 50f;
    public float hitForce = 100f;
    public Transform gunEnd;
    public AudioSource shotSound;

    private Camera fpsCam;
    private WaitForSeconds shotDuration = new WaitForSeconds(.07f);
    private LineRenderer laserLine;
    private float nextFire;

    //Methods
    private void Start()
    {
        laserLine = GetComponent<LineRenderer>();
        fpsCam = GetComponentInParent<Camera>();
    }

    private void Update()
    {
        if(Input.GetButtonDown("Fire1") 
            && Time.deltaTime > nextFire)
        {
            nextFire = Time.deltaTime + fireRate;
        }
    }
}
