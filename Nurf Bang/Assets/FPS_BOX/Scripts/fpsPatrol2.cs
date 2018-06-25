using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fpsPatrol2 : MonoBehaviour {
    public float speed;
    public float startWaitTime;
    public Transform clouds;

    private Transform moveSpot;
    private float waitTime;
    private int randomSpot;

    private void Start()
    {
        waitTime = startWaitTime;
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, moveSpot.position, speed * Time.deltaTime);

        if (Vector3.Distance(transform.position, moveSpot.position) < 0.2f)
        {
            if (waitTime <= 0)
            {
                waitTime = startWaitTime;
            }
            else
            {
                waitTime -= Time.deltaTime;
            }
        }
    }
}