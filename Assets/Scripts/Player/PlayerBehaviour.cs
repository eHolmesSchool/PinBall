using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerBehaviour : MonoBehaviour
{

    [SerializeField] PaddleBehaviour leftPaddle;
    [SerializeField] PaddleBehaviour rightPaddle;
    [SerializeField] SpringBehaviour spring;

    [SerializeField] InputAction useLeft;
    [SerializeField] InputAction useRight;
    [SerializeField] InputAction useSpring;

    private void OnEnable()
    {
        useLeft.Enable();
        useRight.Enable();
        useSpring.Enable();
    }
    private void OnDisable()
    {
        useLeft.Disable();
        useRight.Disable();
        useSpring.Disable();
    }



    void Update()
    {
        leftPaddle.Flip(useLeft.IsPressed());
        rightPaddle.Flip(useRight.IsPressed());
        spring.Lower(useSpring.IsPressed());
    }
}
