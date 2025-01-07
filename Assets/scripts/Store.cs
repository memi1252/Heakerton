using UnityEngine;

public class Store : MonoBehaviour
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
    public void buy(int num)
    {
        if (gameManager.money >=(num / 2 + 1)*10||num==4&& gameManager.money>=15)
        {
            switch (num)
            {
                case 0: gameManager.money -= 10; break;
                case 1: gameManager.money -= 10; break;
                case 2: gameManager.money -= 20; break;
                case 3: gameManager.money -= 20; break;
                case 4: gameManager.money -= 15; break;
            }
            gameManager.ingres[num]++;
        }
    }
}
