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
    private float rotationTime;
    

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //targeting phase 
            relativePosition = player.position - gun.position;
            targetRotation = Quaternion.LookRotation(relativePosition);
            rotating = true;
            rotationTime = 0.0f;
        }


        if (rotating)
        {
            //and a transition phase
            rotationTime += Time.deltaTime * speed;
            transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, rotationTime);
        }

        if (rotationTime > 1)
            rotating = false;
    }

}