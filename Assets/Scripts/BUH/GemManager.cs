using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GemManager //STATIC CLASS doesNOT need an object
{
    public static List<LevelGems> Levels = new List<LevelGems>();
    public static void ResetLevels()
    {
        Levels.Clear();
        Levels.Add(new LevelGems());
    }
}


public struct LevelGems
{
    public int Level;
    private bool[] gems;
    public bool[] Gems { get => gems; set => gems = value; }
}


