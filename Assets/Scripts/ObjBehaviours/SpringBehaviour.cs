using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpringBehaviour : MonoBehaviour
{
    [SerializeField] float lowerAmount = 1;
    float xPos;
    float yPos;

    private void Start()
    {
        xPos = this.GetComponent<Transform>().position.x;
        yPos = this.GetComponent<Transform>().position.y;
    }
    public void Lower(bool isPressed)
    {
        if (isPressed) this.GetComponent<Transform>().position = new Vector2(xPos, yPos - lowerAmount);
    }
}
