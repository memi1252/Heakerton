using System;
using UnityEngine;

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
        state = State.watch;
        if (GameObject.FindWithTag("gamemanager") != gameObject)
        {
            Destroy(gameObject);
        }
        else DontDestroyOnLoad(gameObject);
    }//if (!EventSystem.current.IsPointerOverGameObject ())
}
