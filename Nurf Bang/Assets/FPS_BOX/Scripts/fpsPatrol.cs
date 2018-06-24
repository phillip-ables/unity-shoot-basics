using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fpsPatrol : MonoBehaviour {
    public float speed;
    public Transform[] moveSpots;
    private int randomSpot;

    private void Start()
    {
        randomSpot = Random.Range(0, moveSpots.Length);
    }
}
