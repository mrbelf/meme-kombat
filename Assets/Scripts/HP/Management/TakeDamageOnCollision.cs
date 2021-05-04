using Mirror;
using UnityEngine;

public class TakeDamageOnCollision : NetworkBehaviour, ITakeDamage
{

    [Command]
    public void TakeDamage(int amount, bool player)
    {
        HPManager.Instance.TakeDamage(amount,player);
    }
}
