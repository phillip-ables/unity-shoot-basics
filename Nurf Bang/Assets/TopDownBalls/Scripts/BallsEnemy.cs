using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallsEnemy : MonoBehaviour {
    //Variables
    public float health;
    public float pointsToGive;
    public float waitTime;
    public GameObject bullet;

    private Transform bulletSpawnPoint;
    private Transform pistolHolder;
    private Transform bulletSpawned;
    private GameObject player;
    private float currentTime = 0;
    private bool shot;

    //Methods
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        pistolHolder = this.transform.GetChild(0);
        bulletSpawnPoint = pistolHolder.GetChild(2);
    }

    public void Update()
    {
        if(health <= 0)
        {
            Die();
        }

        this.transform.LookAt(player.transform);

        if(currentTime == 0)
        {
            Shoot();
        }

        if (shot && currentTime < waitTime)
        {
            currentTime += 1 * Time.deltaTime;
        }

        if(currentTime > waitTime)
        {
            currentTime = 0;
        }
    }

    public void Die()
    {
        player.GetComponent<BallsPlayer>().points += pointsToGive;
        Destroy(this.gameObject);
    }

    public void Shoot()
    {
        shot = true;

        bulletSpawned = Instantiate(bullet.transform, bulletSpawnPoint.position, Quaternion.identity);
        bulletSpawned.rotation = this.transform.rotation;
    }
}
