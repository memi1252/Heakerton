using UnityEngine;

public class menuopen : MonoBehaviour
{
    GameManager gameManager;
    void Start()
    {
        gameManager = GameObject.FindWithTag("gamemanager").GetComponent<GameManager>();
    }
    void Update()
    {
        
    }
    public void Onoff()
    {
        if (gameManager.state == State.watch)
        {
            transform.GetChild(0).gameObject.SetActive(!transform.GetChild(0).gameObject.activeSelf);
        }
    }
}
