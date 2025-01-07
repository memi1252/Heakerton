using System.Collections;
using UnityEngine;
using UnityEngine.Tilemaps;

public class objectdelete : MonoBehaviour
{
    Vector3 Position;
    bool TTure;
    float time;
    void Start()
    {
        time = 0;
        TTure = false;
        Position = transform.position;
    }
    void Update()
    {
        if (Position != transform.position)
        {
            time = 0;
            TTure = false;
            Position = transform.position;
        }
        else
        {
            TTure = true;
            time+=Time.deltaTime;
            if (time > 3)
            {
                Destroy(gameObject);
            }
        }
    }
}
