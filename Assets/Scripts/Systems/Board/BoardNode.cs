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
    public GameObject ClickableDisplayObject;
    private GameObject PersonalDisplayNode;

    private bool DisplayNodeActive = false;

    public void SetDisplayNodeActive(bool active)
    {
        DisplayNodeActive = active;
        PersonalDisplayNode.SetActive(active);
    }

    public bool GetDisplayNodeActive()
    {
        return DisplayNodeActive;
    }

    private void Start()
    {
        PersonalDisplayNode = GameObject.Instantiate(ClickableDisplayObject, transform);
        Vector3 currentPost = transform.position;
        currentPost.z = 15;
        PersonalDisplayNode.transform.position = currentPost;
        PersonalDisplayNode.SetActive(false);
    }

    private void Update()
    {
        
    }

    void OnDrawGizmosSelected()
    {
        // Draw a semitransparent blue cube at the transforms position
        Gizmos.color = new Color(1, 0, 0, 0.5f);
        Gizmos.DrawCube(transform.position, new Vector3(1, 1, 1));
    }
}
