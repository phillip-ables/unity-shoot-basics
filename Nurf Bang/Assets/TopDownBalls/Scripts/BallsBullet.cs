using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallsBullet : MonoBehaviour {
    //Variables
    public float bulletSpeed = 7.0f;

    //Method
    private void Update()
    {
        transform.Translate(Vector3.forward * bulletSpeed * Time.deltaTime);
    }
}
