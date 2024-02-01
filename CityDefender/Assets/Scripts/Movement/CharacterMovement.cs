using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    private Rigidbody2D _rb;
    private float _moveSpeed = 5;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        transform.position = new Vector3(-6.82f, 0.4f, 0);
    }

    private void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");  
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 moveInput = new Vector3(horizontalInput, verticalInput, 0);
        Vector3 nextMove = transform.position + moveInput * Time.deltaTime * _moveSpeed;
        _rb.MovePosition(nextMove);
    }



}
