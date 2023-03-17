using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreDisplay : MonoBehaviour
{
    [SerializeField] TMP_Text TMPtext;

    GameObject Judge;
    ScoreCounter scoreCounter;
    void Start()
    {
        
            Judge = GameObject.Find("Judge");
            scoreCounter = Judge.GetComponent<ScoreCounter>();
        
    }

    // Update is called once per frame
    void Update()
    {
        TMPtext.text = $"Score: {scoreCounter.score}";
    }
}
