using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePoint : GameBehaviour<FirePoint>
{
    public GameObject ballPrefab;
    public float ballSpeed = 1000f;
    public bool ballSpawned = false;

    void Start()
    {
       
    }

    private void Update()
    {
        if(_PM.gamemode == PetManager.Gamemode.Playing)
            if (ballSpawned == false)
                ThrowBall(1);
    }

    void ThrowBall(int ballsSpawned)
    {
        GameObject ballInstance;
        ballInstance = Instantiate(ballPrefab, transform.position, transform.rotation);
        ballInstance.GetComponent<Rigidbody>().AddForce(transform.forward * ballSpeed);
        ballSpawned = true;
    }
}
