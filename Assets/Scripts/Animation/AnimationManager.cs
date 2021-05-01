using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(PlayerJump))]
[RequireComponent(typeof(PunchManager))]

public class AnimationManager : MonoBehaviour
{
    private Animator m_animator;
    private Rigidbody2D m_rb;
    private SpriteRenderer m_sr;
    private PlayerJump m_pj;
    private PunchManager m_pm;

    private void Start()
    {
        m_animator = GetComponent<Animator>();
        m_rb = GetComponent<Rigidbody2D>();
        m_sr = GetComponent<SpriteRenderer>();
        m_pj = GetComponent<PlayerJump>();
        m_pj.JumpEvent.AddListener(OnJumpEvent);
        m_pm = GetComponent<PunchManager>();
        m_pm.PunchEvent.AddListener(OnPunchEvent);
    }
    void Update()
    {
        bool walking = Mathf.Abs(m_rb.velocity.x) > .1f;
        m_animator.SetBool("Walking",walking);
        //if (walking) 
        //{
        //    m_sr.flipX = m_rb.velocity.x < 0;
        //}
    }

    private void OnPunchEvent() 
    {
        m_animator.SetTrigger("Punch");
    }

    private void OnJumpEvent() 
    {
        m_animator.SetTrigger("Jump");
    }
}
