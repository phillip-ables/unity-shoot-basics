using UnityEngine;
using System.Collections;

public class LerpRotation : MonoBehaviour
{
    Vector3 relativePosition; // the difference in space
    Quaternion targetRotation;

    public Transform player;
    public Transform gun;
    public float speed = 0.1F;
    private bool rotating = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //targeting phase 
            relativePosition = player.position - gun.position;
            targetRotation = Quaternion.LookRotation(relativePosition);
            rotating = true;
        }


        if (rotating)
        {
            //and a transition phase
            transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, Time.time * speed);
        }
    }

}