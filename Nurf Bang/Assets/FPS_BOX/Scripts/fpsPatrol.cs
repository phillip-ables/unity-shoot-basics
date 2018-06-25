using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fpsPatrol : MonoBehaviour {
    public float speed;
    public float startWaitTime;
    public Transform clouds;

    private Transform[] moveSpots;
    private float waitTime;
    private int randomSpot;

    private void Start()
    {
        randomSpot = Random.Range(0, moveSpots.Length);
        for(int i = 0; i < clouds.childCount; i++)
        {
            moveSpots[i] = clouds.GetChild(i);
        }

    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, moveSpots[randomSpot].position, speed * Time.deltaTime);

        if(Vector3.Distance(transform.position, moveSpots[randomSpot].position) < 0.2f)
        {
            if(waitTime <= 0)
            {
                waitTime = startWaitTime;
                randomSpot = Random.Range(0, moveSpots.Length);
            }
            else
            {
                waitTime -= Time.deltaTime;
            }
        }
    }
}
