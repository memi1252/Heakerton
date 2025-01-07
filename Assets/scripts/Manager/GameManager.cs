using System;
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
    private void Awake()
    {
        money  = 500;
        state = State.place;
        if (GameObject.FindWithTag("gamemanager") != gameObject)
        {
            Destroy(gameObject);
        }
        else DontDestroyOnLoad(gameObject);
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
}
