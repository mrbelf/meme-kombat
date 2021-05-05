using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Core.Utility.SingletonPattern;

public class MultiplayerSettingsHolder : Singleton<MultiplayerSettingsHolder>
{
    public enum ConnectionMode
    {
        Client = 0,
        Host = 1
    }

    public ConnectionMode mode;
    public string playerId;
    public string otherId;
}
