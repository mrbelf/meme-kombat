using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConnectionPlayerDummy : MonoBehaviour
{
    [SerializeField] EventsHolder events;
    void Start()
    {
        events.PlayerConnectionEvent.Invoke();
        Destroy(this.gameObject);
    }
}
