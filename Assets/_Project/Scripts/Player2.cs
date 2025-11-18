using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rb;

    [SerializeField] private float _speed = 5.0f;
    [SerializeField] private float _jumpForce = 10.0f;
    
    private float moveHorizontal;
    private bool isJumping = false;
 
    [SerializeField] int playerNumber;

    // Start is called before the first frame update
    void Start()
    {
        if (_rb == null)
        {
            _rb = GetComponent<Rigidbody2D>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        CheckInput();
    }

    private void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        _rb.velocity = new Vector2(moveHorizontal * _speed, _rb.velocity.y);
        if (isJumping) Jump1();
    }

    public void Jump1()
    {
        _rb.velocity = Vector2.up * _jumpForce;
        isJumping = false;
    }

    void CheckInput()
    {
        if (playerNumber==1)
        {
            moveHorizontal = Input.GetAxis("P1Horizontal");
            if (Input.GetButtonDown("P1Jump"))
            {
                isJumping = true;
            }
        }

        if (playerNumber == 2)
        {
            moveHorizontal = Input.GetAxis("P2Horizontal");
            if (Input.GetButtonDown("P2Jump"))
            {
                isJumping = true;
            }
        }

    }
}

