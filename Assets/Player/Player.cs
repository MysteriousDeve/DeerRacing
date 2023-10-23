using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    private Rigidbody rb;
    private Vector2 moveDir;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + new Vector3(moveDir.x, 0, moveDir.y) * Time.fixedDeltaTime);
    }

    void OnMove(InputValue val)
    {
        moveDir = val.Get<Vector2>();
    }
}
