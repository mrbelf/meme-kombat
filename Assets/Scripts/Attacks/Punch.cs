using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]

public class Punch : MonoBehaviour
{
    [SerializeField] int damageAmount;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.parent != transform.parent) 
        {
            var hpManager = collision.GetComponent<HPManager>();
            Debug.Log("Hit");
            if (hpManager) 
            {
                Debug.Log("Hit hpManager");
                hpManager.TakeDamage(damageAmount);
            }
        }
    }

    public void SetDamage(int damage) { damageAmount = damage;  }
}
