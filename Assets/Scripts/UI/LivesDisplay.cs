using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LivesDisplay : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] TMP_Text textDisplay;
    [SerializeField] GameObject lifeHolder;

    int ballLives;
    private void Start()
    {
        ballLives = lifeHolder.GetComponent<LifeTracker>().lives;
    }
    void Update()
    {
        textDisplay.text = ballLives.ToString();
    }
}
