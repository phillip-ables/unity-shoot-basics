using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallsCameraFX : MonoBehaviour {
    public Animator camShakeAnimation;
    public float walkTime = 0.07f;
    public Transform camFollow;

    private int moveDistance = 5;
    private Vector3 currentPos;

    public void CamShake()
    {
        camShakeAnimation.SetTrigger("Shake");
        StartCoroutine(WalkDownTheHall());
    }

    IEnumerator WalkDownTheHall()
    {
        for(int i = 0; i < moveDistance; i++)
        {
            currentPos = camFollow.position;
            currentPos.z += 1.0f;
            yield return new WaitForSeconds(walkTime);
            camFollow.position = currentPos;
        }
    }
}
