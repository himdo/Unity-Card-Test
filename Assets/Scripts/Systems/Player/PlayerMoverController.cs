using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoverController : MonoBehaviour
{
    public GameObject BoardMasterController;

    public GameObject PlayerIcon;
    [SerializeField]
    private GameObject Player;
    private BoardContoller MasterBoardController;
    // Start is called before the first frame update
    void Start()
    {
        MasterBoardController = BoardMasterController.GetComponent<BoardContoller>();
        Player = GameObject.Instantiate(PlayerIcon);
        Vector3 startingPosition = MasterBoardController.CurrentLocation.transform.position;
        startingPosition.z = 15;
        Player.transform.position = startingPosition;
    }

    // Update is called once per frame
    void Update()
    {
        SetNextMoves(true);
        CheckIfClickedMove();
    }

    void SetNextMoves(bool active)
    {
        BoardNode currentBoardNode = MasterBoardController.CurrentLocation.GetComponent<BoardNode>();
        for (int i = 0; i < currentBoardNode.NodeNeighbors.Count; i++)
        {
            GameObject nextPosition = currentBoardNode.NodeNeighbors[i];
            nextPosition.GetComponent<BoardNode>().SetDisplayNodeActive(active);
        }
    }

    void MoveToObject(GameObject gameObject)
    {
        BoardNode currentBoardNode = MasterBoardController.CurrentLocation.GetComponent<BoardNode>();
        for (int i = 0; i < currentBoardNode.NodeNeighbors.Count; i++)
        {
            if (currentBoardNode.NodeNeighbors[i] == gameObject)
            {
                Debug.Log("FoundObject");
                MasterBoardController.CurrentLocation = gameObject;
                Vector3 startingPosition = gameObject.transform.position;
                startingPosition.z = 15;
                Player.transform.position = startingPosition;
            }
            Debug.Log("did not FoundObject");
        }
    }

    void CheckIfClickedMove()
    {
        if (!Input.GetMouseButtonDown(0)) return;

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 1000))
        {
            Debug.Log(hit.transform.name);
            Debug.Log(hit.transform.name.Contains("NextBoardSphere"));
            if(hit.transform.name.Contains("NextBoardSphere"))
            {
                SetNextMoves(false);
                MoveToObject(hit.transform.parent.gameObject);
            }
        }
    }
}
