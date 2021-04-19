using UnityEngine;
using UnityEngine.Events;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(IGetJumpInput))]

public class PlayerJump : MonoBehaviour
{
    
    [SerializeField] private float jumpForce = 2f;

    private Rigidbody2D rb;
    private IGetJumpInput ji;
    private bool onFloor = false;

    public UnityEvent JumpEvent;

    private void Awake()
    {
        JumpEvent = new UnityEvent();
    }

    void Start()
    {
        ji = GetComponent<IGetJumpInput>();
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (ji.GetJumpDown() && onFloor) 
        {
            JumpEvent.Invoke();
            StartCoroutine(JumpCoroutine());
            onFloor = false;
        }
    }

    private IEnumerator JumpCoroutine() 
    {
        yield return new WaitForSeconds(.2f);
        rb.velocity = new Vector2(rb.velocity.x,jumpForce);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {   
        onFloor = true;
    }
}
