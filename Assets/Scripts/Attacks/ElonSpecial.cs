using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class ElonSpecial : NetworkBehaviour 
{
    [SerializeField]private MovementInputManager m_input;
    [SerializeField]private GameObject car;
    void Start()
    {
        m_input = GetComponent<MovementInputManager>();
    }

    void Update()
    {
        if (m_input.GetSpecial())
            Special();
    }

    [Command]
    void Special() 
    {
        SpawnCar(-transform.localScale.x);
    }

    void SpawnCar(float direction) 
    {
        var c1 = Instantiate(car);
        car.transform.position = this.transform.position;
        car.GetComponent<MoveToDirection>().speed = direction;
        car.transform.localScale = new Vector3(-direction, transform.localScale.y, transform.localScale.z);
        NetworkServer.Spawn(c1);
    }
}
