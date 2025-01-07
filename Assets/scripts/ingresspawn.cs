using System.Collections;
using UnityEngine;

public class ingresspawn : MonoBehaviour
{
    GameManager gameManager;
    public int num;
    bool spawning;

    public GameObject[] ingre;
    void Start()
    {
        spawning = true;
        gameManager = GameObject.FindWithTag("gamemanager").GetComponent<GameManager>();
    }
    void Update()
    {
        if (spawning && gameManager.ingres[num] > 0)
        {
            spawning = false;
            StartCoroutine(spawn());
        }
    }
    IEnumerator spawn()
    {
        yield return new WaitForSeconds(1);
        Instantiate(ingre[num], transform.position - new Vector3(0, 0.5f, 0), transform.rotation);
        if (--gameManager.ingres[num] <= 0)
        {
            spawning = true;
        }
        else
        {
            StartCoroutine(spawn());
        }
    }
}
