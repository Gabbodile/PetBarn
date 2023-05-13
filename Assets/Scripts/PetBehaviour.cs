using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PetBehaviour : GameBehaviour<PetBehaviour>
{
    [Header("Movement")]
    public float minZ = 0, maxZ = 5, minX = -5, maxX = 5;
    NavMeshAgent agent;

    private void Start()
    {
        //Random movement in the set coordinates
        agent = GetComponent<NavMeshAgent>();
        StartCoroutine(Move());
    }

    private void Update()
    {
        //position should be at 0, 0, 0 when returning to this room
    }

    IEnumerator Move()
    {
        Debug.Log("running");
        Vector3 moveToPos = GetRandomPosition();
        agent.SetDestination(moveToPos);
        while (Vector3.Distance(transform.position, moveToPos) < 0.1f)
        {
            yield return null;
        }
        yield return new WaitForSeconds(5);
        StartCoroutine(Move());
    }

    Vector3 GetRandomPosition()
    {
        return new Vector3(Random.Range(minX, maxX), 0, Random.Range(minZ, maxZ));
    }

    //if in washing mode, go to bathroom and sit there
    void Washing()
    {

    }

    //if feeding, go to kitchen
    void Feeding()
    {

    }

}
