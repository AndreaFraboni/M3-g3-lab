using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rb;
    [SerializeField] private float _speed = 5.0f;

    private Vector3 direction;
    private bool isJumping = false;
    private float jumpForce = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        if (_rb==null)
        {
            _rb = GetComponent<Rigidbody2D>();
        }

    }

    // Update is called once per frame
    void Update()
    {
        CheckMovement();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isJumping = true;
            Jump();
        }
    }

    private void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        transform.position = transform.position + direction * (_speed * Time.deltaTime);
    }

    void Jump()
    {
        _rb.velocity = Vector2.up * jumpForce;
        isJumping = false;
    }

    void CheckMovement() // controlla l'Input da tastiera WASD - Tasti freccia .....
    {
        float h = Input.GetAxis("Horizontal");
        direction = new Vector3(h, 0, 0);
    }

}
