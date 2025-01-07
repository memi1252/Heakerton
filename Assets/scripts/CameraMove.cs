using System;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Vector3 lastMousePosition;
    private Camera mainCamera;

    private void Awake()
    {
        mainCamera = Camera.main;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            lastMousePosition = Input.mousePosition;
        }

        if (Input.GetMouseButton(1))
        {
            Vector3 delta = Input.mousePosition - lastMousePosition;
            Vector3 move = new Vector3(-delta.x, -delta.y, 0) * moveSpeed * Time.deltaTime;
            transform.Translate(move);
            lastMousePosition = Input.mousePosition;
        }
        
        if(Input.mouseScrollDelta.y > 0)
        {
            if (mainCamera.orthographicSize > 3)
            {
                mainCamera.orthographicSize -= 0.5f;
                moveSpeed -= 0.1f;
            }
        }
        else if(Input.mouseScrollDelta.y < 0)
        {
            mainCamera.orthographicSize += 0.5f;
            moveSpeed += 0.1f;
        }
    }
}
