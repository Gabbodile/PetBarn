using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyPaddle : GameBehaviour
{
    public Rigidbody ball;
    public Rigidbody rb;
    public Transform player;
    public int speed = 1;

    Vector3 startPos;
    public Transform target;

    void Start()
    {
        startPos = transform.position;
    }

    private void Update()
    {
        if (_PM.gamemode == PetManager.Gamemode.Default)
        {
            startPos = transform.position;
        }

       if (_PM.gamemode == PetManager.Gamemode.Playing)
        {
            transform.LookAt(player);

            if (this.ball.velocity.x > 0.0f)
            {
                if (this.ball.position.z > this.ball.position.z)
                    rb.AddForce(Vector3.left * speed);
                else if (this.ball.position.z < this.transform.position.z)
                    rb.AddForce(Vector3.right * speed);
            }
            else
            {
                if (this.ball.position.z > this.ball.position.z)
                    rb.AddForce(Vector3.left * speed);
                else if (this.ball.position.z < this.transform.position.z)
                    rb.AddForce(Vector3.right * speed);
            }
        }
    }
}

