using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class a : MonoBehaviour
{

    public float speed;

    private Rigidbody2D rb;
    private Vector2 moveV;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Vector2 moveI = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        moveV = moveI.normalized * speed;
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveV * Time.fixedDeltaTime);
    }
}
