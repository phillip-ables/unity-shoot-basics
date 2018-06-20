using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallsEnemy : MonoBehaviour {
    //Variables
    public float health;
    public float pointsToGive;

    private GameObject player;

    //Methods
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    public void Update()
    {
        if(health <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        player.GetComponent<BallsPlayer>().points += pointsToGive;
        Destroy(this.gameObject);
    }
}
