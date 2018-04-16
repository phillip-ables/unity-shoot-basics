using UnityEngine;
using System.Collections;

public class LerpRotation : MonoBehaviour
{
    public Transform from;
    public Transform to;
    public float speed = 0.1F;
    void Update()
    {
        transform.rotation = Quaternion.Lerp(from.rotation, to.rotation, Time.time * speed);
    }
}