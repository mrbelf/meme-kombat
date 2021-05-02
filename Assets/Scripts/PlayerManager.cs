using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]

public class PlayerManager : MonoBehaviour
{
    private SpriteRenderer sr;
    private Transform otherPlayer;

    public void Init(Transform otherPlayer)
    {
        this.otherPlayer = otherPlayer;
    }

    private void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        float Xscale = (otherPlayer.position.x > transform.position.x) ? 1f : -1f ;
        transform.localScale = new Vector3(Xscale,1);
    }
}
