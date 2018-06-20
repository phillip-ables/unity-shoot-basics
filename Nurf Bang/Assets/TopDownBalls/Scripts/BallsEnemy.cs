using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallsEnemy : MonoBehaviour {
    //Variables
    public float health;

    //Methods
    public void Update()
    {
        if(health <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        Debug.Log("ENemyy HAS dies" + this.gameObject.name);
        Destroy(this.gameObject);
    }
}
