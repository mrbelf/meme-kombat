using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(IGetXInput))]
[RequireComponent(typeof(Rigidbody2D))]

public class PlayerHorizontalMove : MonoBehaviour
{
    #region Fields
    [SerializeField] private float speed = 2f;
    #endregion Fields

    #region Variables
    private IGetXInput xInput;
    private Rigidbody2D rb;
    #endregion Variables

    #region Monobehaviour Methods
    private void Start()
    {
        xInput = GetComponent<IGetXInput>();
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        rb.velocity = new Vector2(xInput.GetXInput() * speed, rb.velocity.y);
    }
    #endregion Monobehaviour Methods
}
