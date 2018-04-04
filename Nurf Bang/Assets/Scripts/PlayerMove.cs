using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public CharacterController charController;

    void Awake()
    {
        charController = GetComponent<CharacterController>();
    }
    void Update()
    {
        
    }
}
