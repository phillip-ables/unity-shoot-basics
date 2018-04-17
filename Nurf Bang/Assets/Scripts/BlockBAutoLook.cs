using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockBAutoLook : MonoBehaviour {
    public Transform target;

    private void Update()
    {
        Vector3 relativePos = target.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(relativePos);
        transform.rotation = rotation;
    }
}
