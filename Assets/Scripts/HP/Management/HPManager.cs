using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Core.Utility.SingletonPattern;

public class HPManager : Singleton<HPManager>
{
    [SerializeField] int maxHP = 100;
    [SerializeField] int currentHP = 100;

    public UnityEvent<int> HpUpdateEvent = new UnityEvent<int>();

    public void TakeDamage(int amount) 
    {
        currentHP -= amount;
        HpUpdateEvent.Invoke(currentHP);
    }

    public void ResetHP() 
    {
        currentHP = maxHP;
        HpUpdateEvent.Invoke(currentHP);
    }

    public int GetCurrentHP() => currentHP;
    public int GetMaxtHP() => maxHP;
}
