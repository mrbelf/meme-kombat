using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

[RequireComponent(typeof(NetworkServer))]

public class ServerConnectionManager : MonoBehaviour
{
    private NetworkManager manager;
    private void Awake()
    {
        GetComponent<NetworkManager>();
        manager.maxConnections = 2;
    }
}
