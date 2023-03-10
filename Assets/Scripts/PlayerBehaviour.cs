using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerBehaviour : MonoBehaviour
{

    [SerializeField] PaddleBehaviour leftPaddle;
    [SerializeField] PaddleBehaviour rightPaddle;

    [SerializeField] InputAction useLeft;
    [SerializeField] InputAction useRight;

    private void OnEnable()
    {
        useLeft.Enable();
        useRight.Enable();
    }
    private void OnDisable()
    {
        useLeft.Disable();
        useRight.Disable();
    }


    void Update()
    {
        leftPaddle.Flip(useLeft.IsPressed());
        rightPaddle.Flip(useRight.IsPressed());
    }
}
