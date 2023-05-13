using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody rb;

    private void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("PlayerWall"))
        {
            //Fun +5
            //Hunger -3
            Debug.Log("Lose");
            Destroy(this.gameObject);
        }
        
        if (collision.gameObject.CompareTag("PetWall"))
        {
            //Fun +5
            //Hunger -3
            Debug.Log("Score +1");
            Destroy(this.gameObject);
        }
    }
}
