using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fpsPatrol2 : MonoBehaviour {
    public float speed = 40.0f;
    public float startWaitTime = 3.0f;
    public float minX = -48.0f;
    public float maxX = 442.0f;
    public float minY =   7.6f;
    public float maxY = 489.0f;

    private Transform moveSpot;
    private float waitTime;
    private int randomSpot;

    private void Start()
    {
        waitTime = startWaitTime;
        moveSpot.position = new Vector3(Random.Range(minX, maxX), transform.position.y, Random.Range(minY, maxY));
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, moveSpot.position, speed * Time.deltaTime);

        if (Vector3.Distance(transform.position, moveSpot.position) <= 0.2f)
        {
            if (waitTime <= 0)
            {
                waitTime = startWaitTime;
                moveSpot.position = new Vector3(Random.Range(minX, maxX), transform.position.y, Random.Range(minY, maxY));
            }
            else
            {
                waitTime -= Time.deltaTime;
            }
        }
    }
}