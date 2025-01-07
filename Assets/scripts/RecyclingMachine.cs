using System.Collections;
using TMPro;
using UnityEngine;

public class RecyclingMachine : MonoBehaviour
{
    [SerializeField] private GameObject output;
    
    [SerializeField] private GameObject outputItem;
    [SerializeField] private GameObject[] outputItems;

    [SerializeField] private Sprite[]  RecycleSprites;
    [SerializeField] private GameObject  RecycleView;
    [SerializeField] private GameObject  RecycleSelect;
    
    [SerializeField] private int TrashCount = 0;
    
    [SerializeField] private TextMeshPro TrashCountText;
    
    
    private bool wait = false;

    private void Update()
    {
        if (outputItem == outputItems[0])
        {
            if(TrashCount >= 1  && !wait)
            {
                TrashCount--;
                Instantiate(outputItem, output.transform.position, Quaternion.identity);
                wait = true;
                StartCoroutine(Spawn());
            }
        }else if(outputItem == outputItems[1])
        {
            if(TrashCount >= 1  && !wait)
            {
                TrashCount--;
                Instantiate(outputItem, output.transform.position, Quaternion.identity);
                wait = true;
                StartCoroutine(Spawn());
            }
        }
        else if(outputItem == outputItems[2])
        {
            if(TrashCount >= 1  && !wait)
            {
                TrashCount--;
                Instantiate(outputItem, output.transform.position, Quaternion.identity);
                wait = true;
                StartCoroutine(Spawn());
            }
        }
        
        TrashCountText.text = TrashCount.ToString();
        
        if (Mathf.Approximately(transform.rotation.eulerAngles.z, 0))
        {
            RecycleSelect.transform.localPosition = new Vector3(2.2f, 0, 0);
            RecycleSelect.transform.localRotation = Quaternion.Euler(0, 0, 0);
            RecycleView.transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
        else if (Mathf.Approximately(transform.rotation.eulerAngles.z, 90))
        {
            RecycleSelect.transform.localPosition = new Vector3(0, -2.2f, 0);
            RecycleSelect.transform.localRotation = Quaternion.Euler(0, 0, -90);
            RecycleView.transform.localRotation = Quaternion.Euler(0, 0, -90);
        }
        else if (Mathf.Approximately(transform.rotation.eulerAngles.z, 180))
        {
            RecycleSelect.transform.localPosition = new Vector3(-2.2f,  0, 0);
            RecycleSelect.transform.localRotation = Quaternion.Euler(0, 0, -180);
            RecycleView.transform.localRotation = Quaternion.Euler(0, 0, -180);
        }
        else if (Mathf.Approximately(transform.rotation.eulerAngles.z, 270))
        {
            RecycleSelect.transform.localPosition = new Vector3(0,  2.2f, 0);
            RecycleSelect.transform.localRotation = Quaternion.Euler(0, 0, 90);
            RecycleView.transform.localRotation = Quaternion.Euler(0, 0, 90);
        }
    }

    IEnumerator Spawn()
    {
        yield return new WaitForSeconds(0.7f);
        wait = false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Trash")
        {
            Destroy(other.gameObject);
            TrashCount++;
        }
    }

    public void selectVeiw()
    {
        RecycleSelect.SetActive(true);
    }

    public void Screw()
    {
        RecycleView.GetComponent<SpriteRenderer>().sprite =  RecycleSprites[0];
        outputItem = outputItems[0];
        RecycleSelect.SetActive(false);
    }
    
    public void motor()
    {
        RecycleView.GetComponent<SpriteRenderer>().sprite =  RecycleSprites[1];
        outputItem = outputItems[1];
        RecycleSelect.SetActive(false);
    }

    public void filter()
    {
        RecycleView.GetComponent<SpriteRenderer>().sprite =  RecycleSprites[2];
        outputItem = outputItems[2];
        RecycleSelect.SetActive(false);
    }
    
    public void ElectricWire()
    {
        RecycleView.GetComponent<SpriteRenderer>().sprite =  RecycleSprites[3];
        outputItem = outputItems[3];
        RecycleSelect.SetActive(false);
    }
    
    public void battery()
    {
        RecycleView.GetComponent<SpriteRenderer>().sprite =  RecycleSprites[4];
        outputItem = outputItems[4];
        RecycleSelect.SetActive(false);
    }
}
