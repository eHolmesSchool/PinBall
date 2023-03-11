using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameTester : MonoBehaviour
{
    [SerializeField] InputAction IncreaseScore;
    [SerializeField] InputAction DecreaseScore;
    [SerializeField] InputAction ResetScore;
    [SerializeField] InputAction SaveScore;
    [SerializeField] InputAction LoadScore;
    [SerializeField] InputAction TrySaveHighcore;

    [SerializeField] GameState currentGameState;

    private void Start()
    {
        currentGameState = GameObject.FindGameObjectWithTag("GameState").GetComponent<GameState>() ;
    }

    private void OnEnable()
    {
        IncreaseScore.Enable();
        DecreaseScore.Enable();
        ResetScore.Enable();
        SaveScore.Enable();
        LoadScore.Enable();
        TrySaveHighcore.Enable();
    }

    private void OnDisable()
    {
        IncreaseScore.Disable();
        DecreaseScore.Disable();
        ResetScore.Disable();
        SaveScore.Disable();
        LoadScore.Disable();
        TrySaveHighcore.Disable();
    }

    private void Update()
    {
        if (currentGameState == null)
        {
            currentGameState = GameObject.FindGameObjectWithTag("GameState").GetComponent<GameState>();
        }

        if (IncreaseScore.WasPressedThisFrame())
        {
            IncreaseCurrentScore();
        }
        if (DecreaseScore.WasPressedThisFrame())
        {
            DecreaseCurrentScore();
        }
        if (ResetScore.WasPressedThisFrame())
        {
            ResetCurrentScore();
        }
        if (SaveScore.WasPressedThisFrame())
        {
            SaveCurrentScore();
        }
        if (LoadScore.WasPressedThisFrame())
        {
            LoadCurrentScore();
        }
    }



    void IncreaseCurrentScore()
    {
        currentGameState.score += 1;
        Debug.Log($"Added to Score, now at {currentGameState.score}");
    }

    void DecreaseCurrentScore()
    {
        currentGameState.score -= 1;
        Debug.Log($"Subtracted from Score, now at {currentGameState.score}");
    }

    void ResetCurrentScore()
    {
        currentGameState.score = 0;
        Debug.Log($"Reset Score, now at {currentGameState.score}");
    }

    void SaveCurrentScore()
    {
        FindObjectOfType<GameSaveManager>().SaveToDisk() ;
    }

    void LoadCurrentScore()
    {
        FindObjectOfType<GameSaveManager>().LoadFromDisk();
        Debug.Log($"Loaded Score, now at {currentGameState.score}");
    }

    void TrySaveHighscore()
    {

    }
}
