using Mirror;
using UnityEngine;

public class TakeDamageOnCollision : MonoBehaviour, ITakeDamage
{
    public void TakeDamage(int amount, bool player)
    {
        HPManager.Instance.TakeDamage(amount,player);
    }
}
