using Mirror;
using UnityEngine;

public class TakeDamageOnCollision : NetworkBehaviour, ITakeDamage
{
    [Command(requiresAuthority = false)]
    public void TakeDamage(int amount, bool player)
    {
        HPManager.Instance.TakeDamage(amount,player);
        GetComponent<Rigidbody2D>().AddForce(new Vector2(transform.localScale.x*3,6));
    }
}
