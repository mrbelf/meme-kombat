using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(IGetPunchInput))]

public class PunchManager : MonoBehaviour
{
    public UnityEvent PunchEvent = new UnityEvent();
    private IGetPunchInput m_punchInput;

    private void Start() 
    {
        m_punchInput = GetComponent<IGetPunchInput>();
    }

    private void Update()
    {
        if (m_punchInput.GetPunchDown()) 
        {
            Debug.Log("Do punch stuff");
            PunchEvent.Invoke();
        }
    }
}
