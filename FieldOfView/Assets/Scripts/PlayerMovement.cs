using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float moveSpeed = 5.0f;
    private float rotateSpeed = 5.0f;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.UpArrow))
            rb.MovePosition(rb.position + transform.forward * moveSpeed * Time.fixedDeltaTime);
        float horizontal = Input.GetAxis("Horizontal");
        transform.Rotate(0, horizontal * rotateSpeed, 0);
    }
}
