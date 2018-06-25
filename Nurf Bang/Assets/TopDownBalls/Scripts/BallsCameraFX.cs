using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallsCameraFX : MonoBehaviour {
    public Animator camShakeAnimation;

    public void CamShake()
    {
        camShakeAnimation.SetTrigger("Shake");
    }
}
