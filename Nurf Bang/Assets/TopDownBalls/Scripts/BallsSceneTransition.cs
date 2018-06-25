using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallsSceneTransition : MonoBehaviour {
    public Animator sceneAnimation;
    public Transform enemies;
    public string sceneName;

    private void Update()
    {
        if(enemies.childCount == 0)
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}
