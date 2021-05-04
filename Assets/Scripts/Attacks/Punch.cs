using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

[RequireComponent(typeof(Collider2D))]

public class Punch : NetworkBehaviour
{
    [SerializeField] int damageAmount;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.parent != transform.parent) 
        {
            var hpManager = collision.GetComponent<ITakeDamage>();
            Debug.Log("Hit");
            if (hpManager != null) 
            {
                Debug.Log("Hit hpManager");
                hpManager.TakeDamage(damageAmount, isServer);    
            }
        }
    }

    public void SetDamage(int damage) { damageAmount = damage;  }
}
