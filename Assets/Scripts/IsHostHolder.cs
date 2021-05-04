using UnityEngine;
using Mirror;
public class IsHostHolder : NetworkBehaviour
{
    public override void OnStartServer()
    {
        isHost = isServer;
        base.OnStartServer();
    }
    public static bool isHost;
}
