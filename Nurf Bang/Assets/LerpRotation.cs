using UnityEngine;
using System.Collections;

public class LerpRotation : MonoBehaviour
{
    Vector3 relativePosition; // the difference in space
    Quaternion targetRotation;

    public Transform player;
    public float speed = 0.1F;

    void Update()
    {
        //targeting phase 
        relativePosition = player.position - transform.position;
        targetRotation = Quaternion.LookRotation(relativePosition);


        //and a transition phase

        transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, Time.time * speed);
    }

}