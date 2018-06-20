using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HunchBotEnemy : MonoBehaviour
{
    public float health;

    public Transform player;

    private void Update()
    {
        Vector3 relativePos = player.position - transform.position;
        Quaternion lookRotation = Quaternion.LookRotation(relativePos);
        transform.rotation = lookRotation;


        if (health <= 0)
            Die();
    }

    public void Die()
    {
        Destroy(this.gameObject);
    }
}
