using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallsBullet : MonoBehaviour {
    //Variables
    public float bulletSpeed = 7.0f;
    public float maxDistance;
    public float damage;
    public GameObject blood;

    private GameObject triggeringEnemy;
    private GameObject player;

    //Method
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

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
            Instantiate(blood, transform.position, Quaternion.identity);
            triggeringEnemy = other.gameObject;
            triggeringEnemy.GetComponent<BallsEnemy>().health -= damage;
            Destroy(this.gameObject);
        }

        if(other.tag == "Player")
        {
            Instantiate(blood, transform.position, Quaternion.identity);
            player.GetComponent<BallsPlayer>().health -= damage;
            Destroy(this.gameObject);
        }
    }
}
