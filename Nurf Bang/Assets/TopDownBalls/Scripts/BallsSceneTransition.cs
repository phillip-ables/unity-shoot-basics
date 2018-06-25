using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallsSceneTransition : MonoBehaviour {
    public Animator sceneAnimation;
    public Transform enemies;

    private void Start()
    {
        Debug.Log(enemies.childCount);
    }
}
