using UnityEngine;

public class Switch : MonoBehaviour
{
    bool swi;
    bool stay;
    void Start()
    {
        stay = false;
        swi = true;
    }
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!stay)
        {
            transform.GetChild(0).gameObject.SetActive(false);
            transform.GetChild(1).gameObject.SetActive(false);
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        stay = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        stay = false;
        if (swi)
        {
            transform.GetChild(0).gameObject.SetActive(true);
            transform.GetChild(1).gameObject.SetActive(false);
        }
        else
        {
            transform.GetChild(0).gameObject.SetActive(false);
            transform.GetChild(1).gameObject.SetActive(true);
        }
        swi = !swi;
    }
}
