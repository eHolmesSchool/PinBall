using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

public class PaddleBehaviour : MonoBehaviour
{
    [SerializeField] HingeJoint2D hinge;
    [SerializeField] KeyCode controlName;
    // [SerializeField] float paddleSpeed;


    private void Start()
    {
    }
    void Update()
    {
        Flip(Input.GetKey(controlName)); ;
    }

    public void Flip(bool isPressed)
    {
        hinge.useMotor = isPressed;
    }
}
