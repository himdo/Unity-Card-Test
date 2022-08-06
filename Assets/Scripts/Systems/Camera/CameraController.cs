using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject CameraGameObject;
    public GameObject BoardGameObject;
    private Vector3 MoveDirection = Vector3.zero;
    [SerializeField]
    private float Speed = .1f;
    [SerializeField]
    private float ScrollSpeed = 250.0f;

    private float MaxZoomLevel = 12.0f;
    private float MinZoomLevel = -150.0f;
    private float MinXLevel = -80.0f;
    private float MaxXLevel = 80.0f;
    private float MinYLevel = -60.0f;
    private float MaxYLevel = 60.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveDirection = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), Input.GetAxis("Mouse ScrollWheel") * ScrollSpeed);
        MoveDirection = transform.TransformDirection(MoveDirection);
        MoveDirection *= Speed;

        Vector3 cameraPosition = CameraGameObject.transform.position;
        cameraPosition += MoveDirection;
        if (cameraPosition.z > MaxZoomLevel)
        {
            cameraPosition.z = MaxZoomLevel;
        }
        else if (cameraPosition.z < MinZoomLevel)
        {
            cameraPosition.z = MinZoomLevel;
        }

        if (cameraPosition.x > MaxXLevel)
        {
            cameraPosition.x = MaxXLevel;
        }
        else if (cameraPosition.x < MinXLevel)
        {
            cameraPosition.x = MinXLevel;
        }

        if (cameraPosition.y > MaxYLevel)
        {
            cameraPosition.y = MaxYLevel;
        }
        else if (cameraPosition.y < MinYLevel)
        {
            cameraPosition.y = MinYLevel;
        }
        CameraGameObject.transform.position = cameraPosition;
        Debug.Log(MoveDirection);
    }
}
