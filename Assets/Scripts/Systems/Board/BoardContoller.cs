using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum BoardNodeType
{
    Grass,
    Trainer,
    KnownItem,
    UnknownItem,
    Water,
    Tree,
    Null
}

public class BoardWildPokemonChooser
{
    public int ChanceToAppear;
    public CardObject CardToShow;
}




public class BoardContoller : MonoBehaviour
{
    public GameObject SpawnNode;
    public GameObject CurrentLocation;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
