using UnityEngine;

public class Groundbuy : MonoBehaviour
{
    GameManager gameManager;
    public GameObject on;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameManager = GameObject.FindWithTag("gamemanager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void buyground(int num)
    {
        if (gameManager.items[num] >= 70)
        {
            on.SetActive(true);
            gameManager.items[num] -= 70;
            transform.parent.gameObject.SetActive(false);
        }
    }
}
