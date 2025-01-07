using System.Collections;
using UnityEngine;

public class objectdelete : MonoBehaviour
{
    Vector3 Position;
    bool TTure;
    void Start()
    {
        TTure = false;
        Position = transform.position;
    }
    void Update()
    {
        if (Position != transform.position)
        {
            TTure = false;
            Position = transform.position;
        }
        else
        {
            TTure = true;
            StartCoroutine(dest());
        }
    }
    IEnumerator dest()
    {
        yield return new WaitForSeconds(3);
        if(TTure)Destroy(gameObject);
    }
}
