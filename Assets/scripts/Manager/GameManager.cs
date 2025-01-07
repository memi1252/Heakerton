using System;
using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

public enum State
{
    place,
    watch
};
public class GameManager : MonoBehaviour
{
    public float money;
    public float energy;
    public State state;
    public int[] ingres;
    public int[] items;
    private void Awake()
    {
        money  = 500;
        energy = 500;
        state = State.watch;
        if (GameObject.FindWithTag("gamemanager") != gameObject)
        {
            Destroy(gameObject);
        }
        else DontDestroyOnLoad(gameObject);
        StartCoroutine(energyuse());
    }
    private void Update()
    {
        if (state == State.place)
        {
            Camera.main.transform.GetComponent<Physics2DRaycaster>().enabled = false;
        }
        else if (state == State.watch)
        {
            Camera.main.transform.GetComponent<Physics2DRaycaster>().enabled = true;
        }
    }
    IEnumerator energyuse()
    {
        energy-=GameObject.FindGameObjectsWithTag("ConveyorBelt").Length*2;
        yield return new WaitForSeconds(1);
        yield return StartCoroutine(energyuse());
    }
}
