using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallsEnemyMove : MonoBehaviour {
    //Variables
    public float enemySpeed;
    public float retreatDistance = 3f;


    public float stoppingDistance;
    private Transform player;

    //Methods
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        stoppingDistance = Random.value * 10;
    }

    private void Update()
    {
        if(Vector3.Distance(player.position, gameObject.transform.position) > stoppingDistance)
        {
            transform.position = Vector3.MoveTowards(transform.position, player.position, enemySpeed * Time.deltaTime);
        }
        else if(Vector3.Distance(player.position, gameObject.transform.position) < stoppingDistance 
                    && Vector3.Distance(player.position, gameObject.transform.position) > retreatDistance)
        {
            transform.position = this.transform.position;
        }
        else if(Vector3.Distance(player.position, gameObject.transform.position) <= retreatDistance)
        {
            transform.position = Vector3.MoveTowards(transform.position, player.position, -enemySpeed * Time.deltaTime);
        }
    }
}
