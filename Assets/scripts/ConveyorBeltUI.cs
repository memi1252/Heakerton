using System;
using UnityEngine;
using UnityEngine.UI;

public class ConveyorBeltUI : MonoBehaviour
{
    [SerializeField] private Button ConveyorBelButton;
    [SerializeField] private Button ConveyorBeltRightButton;
    [SerializeField] private Button ConveyorBeltLeftButton;

    private void Awake()
    {
        ConveyorBeltRightButton.onClick.AddListener(() =>
        {
            
                GameManager.Instance.Installation.followObject = Instantiate(GameManager.Instance.Installation.ConveyorBeltRightHover, GameManager.Instance.Installation.mousePosition, Quaternion.identity);
                GameManager.Instance.Installation.spawnObejct = GameManager.Instance.Installation.ConveyorBeltRight;
            
        });
        ConveyorBeltLeftButton.onClick.AddListener(() =>
        {
            
                GameManager.Instance.Installation.followObject = Instantiate(GameManager.Instance.Installation.ConveyorBeltLeftHover, GameManager.Instance.Installation.mousePosition, Quaternion.identity);
                GameManager.Instance.Installation.spawnObejct = GameManager.Instance.Installation.ConveyorBeltLeft;
            
        });
        ConveyorBelButton.onClick.AddListener(() =>
        {
            
                GameManager.Instance.Installation.followObject = Instantiate(GameManager.Instance.Installation.ConveyorBeltHover, GameManager.Instance.Installation.mousePosition, Quaternion.identity);
                GameManager.Instance.Installation.spawnObejct = GameManager.Instance.Installation.ConveyorBelt;
            
        });
    }
}
