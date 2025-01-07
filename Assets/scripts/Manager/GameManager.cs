using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    private void Awake()
    {
        if (GameObject.FindWithTag("gamemanager") != gameObject)
        {
            Destroy(gameObject);
        }
        else DontDestroyOnLoad(gameObject);
    }//if (!EventSystem.current.IsPointerOverGameObject ())
}
