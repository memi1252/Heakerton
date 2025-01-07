using UnityEngine;

public class menuopen : MonoBehaviour
{
    GameManager gameManager;
    public GameObject inven;
    public GameObject store;
    public GameObject setting;
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
    public void Inven()
    {
        if (gameManager.state == State.watch)
        {
            inven.SetActive(!inven.activeSelf);
        }
    }
    public void Store()
    {
        if (gameManager.state == State.watch)
        {
            store.SetActive(!store.activeSelf);
        }
    }
    public void Setting()
    {
        if (gameManager.state == State.watch)
        {
            setting.SetActive(!setting.activeSelf);
        }
    }
}
