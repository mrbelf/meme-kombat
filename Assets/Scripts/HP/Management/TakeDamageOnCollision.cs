using Mirror;
using UnityEngine;

public class TakeDamageOnCollision : NetworkBehaviour, ITakeDamage
{
    [Command(requiresAuthority = false)]
    public void TakeDamage(int amount, bool player)
    {
        HPManager.Instance.TakeDamage(amount,player);
    }
}
