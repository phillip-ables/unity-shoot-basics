using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fpsPatrol : MonoBehaviour {
    public float speed;
    public Transform[] moveSpots;
    public float startWaitTime;

    private float waitTime;
    private int randomSpot;

    private void Start()
    {
        randomSpot = Random.Range(0, moveSpots.Length);
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, moveSpots[randomSpot].position, speed * Time.deltaTime);

        if(Vector3.Distance(transform.position, moveSpots[randomSpot].position) < 0.2f)
        {

        }
    }
}
