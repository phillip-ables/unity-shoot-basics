using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotor : MonoBehaviour {
    private CharacterController character;

    private float verticalVelocity;
    private float gravity = 14.0f;
    private float jumpForce = 10.0f;

    private void Start()
    {
        character = GetComponent<CharacterController>();
    }
}
