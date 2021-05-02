using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class GameManager : NetworkBehaviour
{
    [SerializeField] EventsHolder eh;
    [SerializeField] private int playersCount = 0;

    [SerializeField] GameObject playerPrefab;

    private void Awake()
    {
        eh.PlayerConnectionEvent.AddListener(OnPlayerConnectEvent);
    }

    private void OnPlayerConnectEvent()
    {
        Debug.Log("Player connected");
        playersCount++;
        TryInitGame();
    }

    private void TryInitGame() 
    {
        if (playersCount == 2) 
        {
            if(isServer)
                InitGame();
        }
    }

    private void InitGame()
    {
        //Instantiating players
        var p1 = InstantiatePlayer("p1",Vector3.right);
        var p2 = InstantiatePlayer("p2",Vector3.left);

        //Setting players oponents as each other
        p1.Init(p2.transform);
        p2.Init(p1.transform);

        //Giving authority to players over their chars
        var connectionEnum = NetworkServer.connections.Values.GetEnumerator();
        NetworkServer.AddPlayerForConnection(connectionEnum.Current,p1.gameObject);
        connectionEnum.MoveNext();
        NetworkServer.AddPlayerForConnection(connectionEnum.Current,p2.gameObject);

        

    }

    private PlayerManager InstantiatePlayer(string PlayerId,Vector3 position) 
    {
        var player = Instantiate(playerPrefab);
        player.transform.position = position;
        return player.GetComponent<PlayerManager>();
    }

    private void OnPlayerDisconnectEvent()
    {
        Debug.Log("Player Disconnectd");
        playersCount--;
    }
}
