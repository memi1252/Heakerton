using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class ProductionMachine : MonoBehaviour
{
    [SerializeField] private GameObject output;
    
    [SerializeField] private GameObject outputItem;
    [SerializeField] private GameObject[] outputItems;

    [SerializeField] private Sprite[] ItmeSprites;
    [SerializeField] private GameObject ItemView;
    [SerializeField] private GameObject ItemSelect;
    
    [SerializeField] private int ScrewCount = 0;
    [SerializeField] private int batteryCount = 0;
    [SerializeField] private int motorCount = 0;
    [SerializeField] private int ElectricWireCount = 0;
    [SerializeField] private int filterCount = 0;
    
    [SerializeField] private TextMeshPro ScrewCountText;
    [SerializeField] private TextMeshPro batteryCountText;
    [SerializeField] private TextMeshPro motorCountText;
    [SerializeField] private TextMeshPro ElectricWireCountText;
    [SerializeField] private TextMeshPro filterCountText;
    
    private bool wait = false;

    private void Update()
    {
        if (outputItem == outputItems[0])
        {
            if(ScrewCount >= 1 && motorCount >= 1 && ElectricWireCount >= 1 && batteryCount >= 1 && !wait)
            {
                ScrewCount--;
                motorCount--;
                ElectricWireCount--;
                batteryCount--;
                Instantiate(outputItem, output.transform.position, Quaternion.identity);
                wait = true;
                StartCoroutine(Spawn());
            }
        }else if(outputItem == outputItems[1])
        {
            if(ScrewCount >= 1 && filterCount >= 1 && batteryCount >= 1 && motorCount >= 1 && !wait)
            {
                ScrewCount--;
                filterCount--;
                batteryCount--;
                motorCount--;
                Instantiate(outputItem, output.transform.position, Quaternion.identity);
                wait = true;
                StartCoroutine(Spawn());
            }
        }
        else if(outputItem == outputItems[2])
        {
            if(ScrewCount >= 1 && filterCount >= 1 && batteryCount >= 1 && ElectricWireCount >= 1 && !wait)
            {
                ScrewCount--;
                filterCount--;
                batteryCount--;
                ElectricWireCount--;
                Instantiate(outputItem, output.transform.position, Quaternion.identity);
                wait = true;
                StartCoroutine(Spawn());
            }
        }
        
        ScrewCountText.text = ScrewCount.ToString();
        batteryCountText.text = batteryCount.ToString();
        motorCountText.text = motorCount.ToString();
        ElectricWireCountText.text = ElectricWireCount.ToString();
        filterCountText.text = filterCount.ToString();
    }

    IEnumerator Spawn()
    {
        yield return new WaitForSeconds(0.7f);
        wait = false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Screw")
        {
            Destroy(other.gameObject);
            ScrewCount++;
        }else if(other.gameObject.tag == "battery")
        {
            Destroy(other.gameObject);
            batteryCount++;
        }else if (other.gameObject.tag == "motor")
        {
            Destroy(other.gameObject);
            motorCount++;
        }else if (other.gameObject.tag == "ElectricWire")
        {
            Destroy(other.gameObject);
            ElectricWireCount++;
        }else if (other.gameObject.tag == "filter")
        {
            Destroy(other.gameObject);
            filterCount++;
        }
    }

    public void selectVeiw()
    {
        ItemSelect.SetActive(true);
    }

    public void sprinkler()
    {
        ItemView.GetComponent<SpriteRenderer>().sprite = ItmeSprites[0];
        outputItem = outputItems[0];
        ItemSelect.SetActive(false);
    }
    
    public void ozonegenerator()
    {
        ItemView.GetComponent<SpriteRenderer>().sprite = ItmeSprites[2];
        outputItem = outputItems[2];
        ItemSelect.SetActive(false);
    }

    public void AirPurifier()
    {
        ItemView.GetComponent<SpriteRenderer>().sprite = ItmeSprites[1];
        outputItem = outputItems[1];
        ItemSelect.SetActive(false);
    }
}
