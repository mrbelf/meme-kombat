using UnityEngine;
using UnityEngine.Events;
using System;
using Mirror;


public class HPManager : NetworkBehaviour
{
    #region Singleton
    public static HPManager Instance;
    [SerializeField] private GameObject looserPopup;
    [SerializeField] private GameObject winnerPopup;
    private void Awake()
    {
        if (Instance)
            Destroy(this);
        else
            Instance = this;
    }
    #endregion Singleton
    [SerializeField] int maxHP = 100;
    [SerializeField] [SyncVar] int hp1 = 100;
    [SerializeField] [SyncVar] int hp2 = 100;

    public UnityEvent<int,int> HpUpdateEvent = new UnityEvent<int,int>();

    [ClientRpc]
    public void TakeDamage(int amount, bool player1) 
    {
        if (player1)
        {
            hp1 -= amount;
        }
        else 
        {
            hp2 -= amount;
        }
        HpUpdateEvent.Invoke(hp1,hp2);

        if (hp1 <= 0 || hp2 <= 0) 
        {
            if (hp1 <= 0)
            {
                winnerPopup.SetActive(!IsHostHolder.isHost);
                looserPopup.SetActive(IsHostHolder.isHost);
            }
            else 
            {
                winnerPopup.SetActive(IsHostHolder.isHost);
                looserPopup.SetActive(!IsHostHolder.isHost);
            }
            ResetHP();
        }
    }

    public void ResetHP() 
    {
        hp1 = hp2 = maxHP;
        HpUpdateEvent.Invoke(hp1,hp2);
    }

    public Tuple<int,int> GetCurrentHP() => new Tuple<int, int>(hp1,hp2);
    public int GetMaxtHP() => maxHP;
}
