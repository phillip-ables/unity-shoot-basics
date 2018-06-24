using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fpsGhostSpwan : MonoBehaviour {
    public GameObject ghost;

    private void Start()
    {
        Debug.Log(transform.childCount);
        for(int i = 0; i < transform.childCount; i++)
        {
            Instantiate(ghost, transform.GetChild(i).position, Quaternion.identity);
            Debug.Log(transform.GetChild(i).position);
        }
    }
}
