using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]

public class PlayerManager : MonoBehaviour
{
    private SpriteRenderer sr;
    private Rigidbody2D rb;
    private Transform otherPlayer;

    public void Init(Transform otherPlayer)
    {
        this.otherPlayer = otherPlayer;
    }

    private void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Mathf.Abs(rb.velocity.x) > 0.1)
            transform.localScale = new Vector3((rb.velocity.x < 0) ? -1:1, 1) ;
    }
}
