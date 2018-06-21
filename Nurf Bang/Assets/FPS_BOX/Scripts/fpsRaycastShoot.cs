using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fpsRaycastShoot : MonoBehaviour {
    public int gunDamage = 1;
    public float fireRate = .25f;
    public float weaponRange = 50f;
    public float hitForce = 100f;
    public Transform gunEnd;

    private Camera fpsCam;
    private WaitForSeconds shotDuration = new WaitForSeconds(.07f);
    private AudioSource shotAudio;
    private LineRenderer laserLine;
    private float nextFire;

}
