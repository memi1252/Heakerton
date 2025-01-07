using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Installation : MonoBehaviour
{
    [SerializeField] private float distance = 100f;
    [SerializeField] public GameObject ConveyorBelt;
    [SerializeField] public GameObject ConveyorBeltRight;
    [SerializeField] public GameObject ConveyorBeltLeft;
    [SerializeField] public GameObject ConveyorBeltHover;
    [SerializeField] public GameObject ConveyorBeltRightHover;
    [SerializeField] public GameObject ConveyorBeltLeftHover;
    
    
    private Camera mainCamera;
    public Vector2 mousePosition;
    public GameObject spawnObejct;
    public GameObject followObject;

    private void Awake()
    {
        mainCamera = Camera.main;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            followObject = Instantiate(ConveyorBeltHover, mousePosition, Quaternion.identity);
        }else if (Input.GetKeyDown(KeyCode.R) && followObject != null)
        {
            followObject.transform.Rotate(0, 0, -90);
        }
        
        mousePosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        RaycastHit2D hit;
        hit = Physics2D.Raycast(mousePosition, Vector2.zero);
        if(hit)
        {
            if (hit.collider.CompareTag("tilte"))
            {
                if(followObject != null)
                {
                    followObject.transform.position = hit.collider.transform.position;
                    if (Input.GetMouseButtonDown(0) && !hit.collider.CompareTag("ConveyorBelt"))
                    {
                        var obejct = Instantiate(spawnObejct, hit.collider.transform.position, followObject.transform.rotation);
                        Destroy(followObject);
                        hit.collider.gameObject.SetActive(false);
                    }
                }
            }
        }
    }
}
