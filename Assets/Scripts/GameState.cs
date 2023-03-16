using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : MonoBehaviour
{
    public int score = 0;

    void Awake()//Once ever when Script is loaded
    {
        GameObject[] obj = GameObject.FindGameObjectsWithTag("GameState");
        if (obj.Length > 1)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }
}