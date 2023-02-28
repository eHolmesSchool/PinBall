using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BallDebug : MonoBehaviour
{
    Rigidbody2D rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            SetBall(Camera.main.ScreenToWorldPoint(Mouse.current.position.value));
        }
    }

    public void SetBall(Vector2 pos)
    {
        rigidbody.position = pos;
        rigidbody.velocity = new Vector2(0, 0);
    }
}
