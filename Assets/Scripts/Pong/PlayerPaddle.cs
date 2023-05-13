using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPaddle : GameBehaviour
{
    public Rigidbody rb;
    public int speed;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.A))
            rb.MovePosition(transform.position + Vector3.left * speed * Time.deltaTime);
        
        if (Input.GetKey(KeyCode.D))
            rb.MovePosition(transform.position + Vector3.right * speed * Time.deltaTime);
    }
}
