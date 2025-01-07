using System;
using UnityEngine;

public class ConveyorBelt : MonoBehaviour
{
    public float StaigntSpeed;
    
    private void OnTriggerStay2D(Collider2D other)
    {
        other.transform.Translate(transform.up * StaigntSpeed * Time.deltaTime);
    }
}
