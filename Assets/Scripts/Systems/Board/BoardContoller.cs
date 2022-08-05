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
    Null
}

public class BoardWildPokemonChooser
{
    public int ChanceToAppear;
    public CardObject CardToShow;
}


[Serializable]
[CreateAssetMenu(fileName = "Node", menuName = "Tools/BoardNodes")]
public class BoardNodeObject :ScriptableObject
{
    public BoardNodeType NodeType;
    public List<BoardWildPokemonChooser> WildPokemonAtNode;
    [SerializeField]
    public ItemObject ItemAtNode;
    public TrainerObject TrainerAtNode;
    public List<BoardNodeObject> NodeNeighbors;
    public BoardLocation LocationOnBoard;
    public GameObject GameObjectRepresentation;
}

public class BoardContoller : MonoBehaviour
{
    public Sprite Board;
    public List<BoardNodeObject> BoardNodes = new List<BoardNodeObject>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
