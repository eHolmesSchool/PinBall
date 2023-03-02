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

    private void OnDisable()
    {
        useLeft.Disable();
        useRight.Disable();
    }



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        leftPaddle.Flip(useLeft.ReadValue<bool>());
        rightPaddle.Flip(useRight.ReadValue<bool>());
    }
}
