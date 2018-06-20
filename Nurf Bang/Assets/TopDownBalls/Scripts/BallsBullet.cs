﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallsBullet : MonoBehaviour {
    //Variables
    public float bulletSpeed = 7.0f;
    public float maxDistance;
    public float damage;

    private GameObject triggeringEnemy;

    //Method
    private void Update()
    {
        transform.Translate(Vector3.forward * bulletSpeed * Time.deltaTime);
        maxDistance += 1 * Time.deltaTime;

        if(maxDistance >= 2)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Enemy")
        {
            triggeringEnemy = other.gameObject;
            triggeringEnemy.GetComponent<BallsEnemy>().health -= damage;
            Destroy(this.gameObject);
        }
    }
}
