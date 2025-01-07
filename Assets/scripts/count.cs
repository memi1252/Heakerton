using TMPro;
using UnityEngine;

public enum Count
{
    energy,
    money,
    ingre
}
public class count : MonoBehaviour
{
    float num;
    GameManager gameManager;
    public Count counT;
    public int l;
    void Start()
    {
        num = 0;
        gameManager = GameObject.FindWithTag("gamemanager").GetComponent<GameManager>();
    }
    void Update()
    {
        switch (counT)
        {
            case Count.energy:num=gameManager.energy; break;
            case Count.money: num = gameManager.money; break;
            case Count.ingre: num = gameManager.ingres[l]; break;
        }
        GetComponent<TMP_Text>().text = num.ToString("#,##0");
    }
}
