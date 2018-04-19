using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float aliveTime;
    public float damage;
    public float moveSpeed;

    private void Update()
    {
        aliveTime -= Time.deltaTime;

        if (aliveTime <= 0)
            Destroy(this.gameObject);

        this.transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);
    }
}
