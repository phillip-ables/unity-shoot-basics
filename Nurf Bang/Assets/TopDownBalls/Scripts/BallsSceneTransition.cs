using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallsSceneTransition : MonoBehaviour {
    public Animator transAnimation;
    public Transform enemies;
    public string sceneName;
    public float transWait = 1.5f;

    private void Start()
    {
        transAnimation.SetTrigger("Start");
    }

    private void Update()
    {
        if(enemies.childCount == 0)
        {
            StartCoroutine(LoadScene());
        }
    }

    IEnumerator LoadScene()
    {
        transAnimation.SetTrigger("End");
        Debug.Log("END");
        yield return new WaitForSeconds(transWait);
        SceneManager.LoadScene(sceneName);
    }
}
