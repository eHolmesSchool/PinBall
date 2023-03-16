using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem.LowLevel;

public class GameSaveManager : MonoBehaviour
{
    protected GameState gameState;
    string desiredPath;
    [SerializeField] TMP_Text scoreField;
    //UI reference

    private void Awake()
    {
        desiredPath = Path.Combine(Application.persistentDataPath, "Pinball_Highscore.txt");
        Debug.Log(desiredPath);
    }
    private void Start()
    {
        gameState = GameObject.FindGameObjectWithTag("GameState").GetComponent<GameState>() ;
        //UI reference 
    }

    private void Update()
    {
        scoreField.text = $"{gameState.score}";
    }

    public void LoadFromDisk()
    {//The Application part is the default Unity thing, we combine this with the actual name of the file we want to save it too
        
        if (File.Exists(desiredPath))
        {
            using (StreamReader streamReader = File.OpenText(desiredPath))
            {   //json is just a language that makes file saving code a bit more readabe for humans
                string jsonString = streamReader.ReadToEnd();

                JsonUtility.FromJsonOverwrite(jsonString, gameState);
            }
        }
    }

    public void SaveToDisk()
    {
        Debug.Log("TRIED SAVING");
        string jsonString = JsonUtility.ToJson(gameState);
        using (StreamWriter streamWriter = File.CreateText(desiredPath))
        {
            streamWriter.Write(jsonString);
            Debug.Log($"Saved {gameState.score}");
        }
    }
}