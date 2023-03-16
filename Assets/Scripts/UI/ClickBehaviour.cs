using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ClickBehaviour : MonoBehaviour
{
    string LevelName = "Level1";

    public void LoadFirstLevel()
    {
        Debug.Log (LevelName) ;
        SceneManager.LoadScene(LevelName);
    }
}