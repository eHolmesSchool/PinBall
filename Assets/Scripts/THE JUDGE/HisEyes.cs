using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HisEyes : MonoBehaviour
{
    public int scoreTotal = 0;

    public int playerStatus = -1; //-1 == notPlayed, 0 == Lost, 1 == Won, 11 == error (not used now but may later for trycatches and the like)

    public void Awake()
    {
        playerStatus = -1;
    }
    private void Update()
    {

    }
}