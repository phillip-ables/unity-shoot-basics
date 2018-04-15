using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereControllerTransform : MonoBehaviour {
    private string moveInputAxis = "Vertical";
    private string turnInputAxis = "Horizontal";

    public float rotationRate = 360;

    public float moveSpeed = 2;

    #region Monobehaviour API
    private void Update()
    {
        float moveAxis = Input.GetAxis(moveInputAxis);
        float turnAxis = Input.GetAxis(turnInputAxis);

        ApplyInput(moveAxis, turnAxis);

    }

    private void ApplyInput(float moveInput,
                            float turnInput)
    {
        Move(moveInput);
        Turn(turnInput);
    }

    private void Move(float input)
    {

    }

    private void Turn(float input)
    {

    }

    #endregion
}
