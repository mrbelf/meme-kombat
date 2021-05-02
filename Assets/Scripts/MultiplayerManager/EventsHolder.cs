using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "EventsHolder",menuName = "New EventsHolder")]

public class EventsHolder : ScriptableObject
{
    public UnityEvent PlayerConnectionEvent;
    public UnityEvent WinnerEvent;
    public UnityEvent PlayerDisconnectEvent;
}
