using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICollectable
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

//Public interface ICollectable //what should All collectables do? (just in general)
//{
//    Public int value { get; set; } //Increment some value
//    Public int Collect(); //Have a “Collect” method. Removes itself from the scene
//    Public collectableType type {get; }
//}

//[System.Flags]

//Public enum CollectabeType
//{
//    None = 0,
//    Money = 1,
//    Key = 2,
//    Gem = 4,
//    Special = Money | Gem //Specials Int is 5
//}