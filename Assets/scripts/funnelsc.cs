using UnityEngine;

public class funnelsc : MonoBehaviour
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
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("spring"))
        {
            gameManager.items[0]++;   
        }else if (other.gameObject.CompareTag("air"))
        {
            gameManager.items[1]++;
        }
        else if (other.gameObject.CompareTag("ozon"))
        {
            gameManager.items[2]++;
        }
        Destroy(other.gameObject);
    }
}
