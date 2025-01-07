using UnityEngine;

public class inven : MonoBehaviour
{
    GameManager gameManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameManager = GameObject.FindWithTag("gamemanager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void sell(int num)
    {
        if (gameManager.items[num] > 0)
        {
            gameManager.items[num]--;
            switch (num)
            {
                case 0: gameManager.money += 90; break;
                case 1: gameManager.money += 100; break;
                case 2: gameManager.money += 85; break;
            }
        }
    }
}
