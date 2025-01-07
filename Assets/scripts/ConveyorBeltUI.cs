using System;
using UnityEngine;
using UnityEngine.UI;

public class ConveyorBeltUI : MonoBehaviour
{
    GameManager gameManager;
    private void Awake()
    {
        gameManager = GameObject.FindWithTag("gamemanager").GetComponent<GameManager>();
    }
}
