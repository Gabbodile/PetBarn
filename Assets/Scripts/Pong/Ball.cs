using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : GameBehaviour
{
    public Rigidbody rb;

    private void update()
    {
        Destroy(this.gameObject, 10);

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
    }
}
