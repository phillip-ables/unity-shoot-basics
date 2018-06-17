using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallsBullet : MonoBehaviour {
    //Variables
    public float bulletSpeed = 7.0f;
    public float maxDistance;

    //Method
    private void Update()
    {
        transform.Translate(Vector3.forward * bulletSpeed * Time.deltaTime);
        maxDistance += 1 * Time.deltaTime;

        if(maxDistance >= 5)
        {
            Destroy(this.gameObject);
        }
    }
}
