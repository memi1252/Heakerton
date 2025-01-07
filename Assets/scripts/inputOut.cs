using System;
using UnityEngine;
using UnityEngine.UI;

public class inputOut : MonoBehaviour
{
    [SerializeField] private GameObject output;

    [SerializeField] private string inputItemTag;
    [SerializeField] private GameObject outputItem;

    [SerializeField] private Sprite[] ItmeSprites;
    [SerializeField] private GameObject ItemView;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("OnTriggerEnter2D");
        if(other.gameObject.tag == inputItemTag)
        {
            Destroy(other.gameObject);
            Instantiate(outputItem, output.transform.position, Quaternion.identity);
        }
    }
}
