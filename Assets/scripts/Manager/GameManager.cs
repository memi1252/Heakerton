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
    public State state;
    private void Awake()
    {
        state = State.place;
        if (GameObject.FindWithTag("gamemanager") != gameObject)
        {
            Destroy(gameObject);
        }
        else DontDestroyOnLoad(gameObject);
    }//if (!EventSystem.current.IsPointerOverGameObject ())
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
