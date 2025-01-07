using UnityEngine;

public class place_onoff : MonoBehaviour
{
    Animator animator;
    public GameObject place_window;
    GameManager gameManager;
    void Start()
    {
        
        gameManager = GameObject.FindWithTag("gamemanager").GetComponent<GameManager>();
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        
    }
    public void onoff()
    {
        animator.SetTrigger("click");
        place_window.SetActive(!place_window.activeSelf);
        if (gameManager.state == State.watch)
        {
            gameManager.state = State.place;
        }
        else if (gameManager.state == State.place)
        {
            gameManager.state = State.watch;
        }
    }
}
