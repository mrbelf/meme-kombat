using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToDirection : MonoBehaviour
{
    public Vector3 direction;
    public float speed;

    private void Start()
    {
        if (direction.x < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        else 
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
    }

    void Update()
    {
        transform.position += direction * speed * Time.deltaTime;
    }
}
