using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : GameBehaviour
{
    public float spawnRange = 9;
    public GameObject[] foods;

    private void Update()
    {
        if(_PM.gamemode == PetManager.Gamemode.Feeding)
            StartCoroutine(SpawnFood());
    }

    IEnumerator SpawnFood()
    {
        while (_PM.gamemode == PetManager.Gamemode.Feeding)
        {
            Instantiate(foods[3], RandomSpawnPos(), foods[3].transform.rotation);
        }
        yield return new WaitForSeconds(3);
    }

    private Vector3 RandomSpawnPos()
    {
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);
        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosZ);
        return randomPos;
    }
}
