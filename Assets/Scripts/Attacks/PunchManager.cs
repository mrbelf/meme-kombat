using DG.Tweening;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(IGetPunchInput))]

public class PunchManager : MonoBehaviour
{
    public UnityEvent PunchEvent = new UnityEvent();
    private IGetPunchInput m_punchInput;

    [Header("PunchAnimation")]
    [SerializeField] private Vector3 punchLocalOrigin;
    [SerializeField] private Vector3 punchLocalTarget;
    [SerializeField] private float punchDuration;
    [SerializeField] private BoxCollider2D punch;

    private bool punching = false;

    private void Start() 
    {
        m_punchInput = GetComponent<IGetPunchInput>();
        punch.enabled = false;
    }

    private void Update()
    {
        if (m_punchInput.GetPunchDown()) 
        {
            if(!punching)
                Punch();
            PunchEvent.Invoke();
        }
    }

    private void Punch() 
    {
        punching = true;
        punch.enabled = true;
        punch.transform.localPosition = punchLocalOrigin;
        punch.transform.DOLocalMove(punchLocalTarget,punchDuration).OnComplete(()=> { punching = false; punch.enabled = false; });
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        if(punch)
            Gizmos.DrawWireCube(punch.bounds.center,punch.bounds.size);

        Gizmos.DrawLine(punchLocalOrigin,punchLocalTarget);
    }
}
