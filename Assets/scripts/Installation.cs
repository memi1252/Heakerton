using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class Installation : MonoBehaviour
{
    [SerializeField] private float distance = 100f;
    [SerializeField] public GameObject ConveyorBelt;
    [SerializeField] public GameObject ConveyorBeltRight;
    [SerializeField] public GameObject ConveyorBeltLeft;
    [SerializeField] public GameObject ProductionMachine;
    [SerializeField] public GameObject Generator;


    [SerializeField] public GameObject ConveyorBeltHover;
    [SerializeField] public GameObject ConveyorBeltRightHover;
    [SerializeField] public GameObject ConveyorBeltLeftHover;
    [SerializeField] public GameObject ProductionMachineHover;
    [SerializeField] public GameObject GeneratorHover;

    [SerializeField] public GameObject DeleteObject;

    private Camera mainCamera;
    public Vector2 mousePosition;
    GameObject selectedObject;
    public GameObject spawnObejct;
    public GameObject followObject;
    GameManager gameManager;
    bool Delete;

    private void Awake()
    {
        Delete = false;
        gameManager = GameObject.FindWithTag("gamemanager").GetComponent<GameManager>();
        mainCamera = Camera.main;
    }

    private void Update()
    {
        if (gameManager.state == State.watch)
        {
            selectedObject = null;
            Destroy(followObject);
        }
        if (Input.GetKeyDown(KeyCode.R) && followObject != null)
        {
            followObject.transform.Rotate(0, 0, -90);
        }
        mousePosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        RaycastHit2D hit;
        hit = Physics2D.Raycast(mousePosition, Vector2.zero);
        if(hit&& !EventSystem.current.IsPointerOverGameObject())
        {
            if (hit.collider.CompareTag("tilte"))
            {
                if (followObject != null)
                {
                    followObject.transform.position = hit.collider.transform.position;
                    if (Input.GetMouseButtonDown(0) && !hit.collider.CompareTag("ConveyorBelt")&&!Delete)
                    {
                        var obejct = Instantiate(spawnObejct, hit.collider.transform.position, followObject.transform.rotation);
                    }
                }
            }else
            {
                if (Delete)
                {
                    followObject.transform.position = hit.collider.transform.position;
                    if (Input.GetMouseButtonDown(0) && hit.collider.CompareTag("ConveyorBelt"))
                    {
                        Destroy(hit.transform.gameObject);
                    }else if(Input.GetMouseButtonDown(0) && hit.collider.CompareTag("child"))
                    {
                        Destroy(hit.transform.parent.gameObject);
                    }
                }
            }
        }
    }
    public void setObject(int num)
    {
        Delete = false;
        if(followObject!=null)Destroy(followObject);
        switch (num)
        {
            case 0: selectedObject = ConveyorBeltHover; spawnObejct = ConveyorBelt; break;
            case 1: selectedObject = ConveyorBeltRightHover; spawnObejct = ConveyorBeltRight; break;
            case 2: selectedObject = ConveyorBeltLeftHover; spawnObejct = ConveyorBeltLeft; break;
            case 3: selectedObject = ProductionMachineHover; spawnObejct = ProductionMachine; break;
            case 4: selectedObject = GeneratorHover; spawnObejct = Generator; break;
        }
        followObject = Instantiate(selectedObject, mousePosition, selectedObject.transform.rotation);
    }
    public void delete()
    {
        Delete = true;
        if (followObject != null) Destroy(followObject);
        followObject = Instantiate(DeleteObject, mousePosition, followObject.transform.rotation);
    }
}
