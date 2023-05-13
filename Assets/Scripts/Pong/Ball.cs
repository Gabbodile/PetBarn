using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : GameBehaviour
{
    public Rigidbody rb;
    public int speed = 1;

    private void update()
    {
        rb = GetComponent<Rigidbody>();

        if (_PM.gamemode == PetManager.Gamemode.Default)
            Destroy(this.gameObject);

        if (Input.GetKeyDown(KeyCode.R))
        {
            Destroy(this.gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Paddle"))
        {
            float x = Random.value < 0.5f ? Random.Range(-1.0f, 1.0f) : Random.Range(-1.0f, 1.0f);
            float z = 0;

            Vector3 direction = new Vector3(x, z);
            rb.AddForce(direction * speed);
        }
            
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerWall"))
        {
            //Fun +5
            //Hunger -3
            Debug.Log("Lose");
            Destroy(this.gameObject);
            _FP.ballSpawned = false;
        }
        
        if (other.CompareTag("PetWall"))
        {
            //Fun +5
            //Hunger -3
            Debug.Log("Score +1");
            Destroy(this.gameObject);
            _FP.ballSpawned = false;
        }

        if (other.CompareTag("FoodFloor"))
        {
            Destroy(this.gameObject);
            _FP.ballSpawned = false;
        }
    }
}
