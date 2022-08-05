using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardNode : MonoBehaviour
{
    public BoardNodeType NodeType;
    public List<BoardWildPokemonChooser> WildPokemonAtNode;
    [SerializeField]
    public ItemObject ItemAtNode;
    public TrainerObject TrainerAtNode;
    public List<GameObject> NodeNeighbors;
    public BoardLocation LocationOnBoard;

    void OnDrawGizmosSelected()
    {
        // Draw a semitransparent blue cube at the transforms position
        Gizmos.color = new Color(1, 0, 0, 0.5f);
        Gizmos.DrawCube(transform.position, new Vector3(1, 1, 1));
    }
}
