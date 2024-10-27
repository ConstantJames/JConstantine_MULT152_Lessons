using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    private float spawnRange = 8.5f;

    // Start is called before the first frame update
    void Start()
    {
        //Vector3 genPos = GenerateSpawnPosition();
        Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation);
    }

    Vector3 GenerateSpawnPosition()
    {
        float xPos = Random.Range(-spawnRange, spawnRange);
        float zPos = Random.Range(-spawnRange, spawnRange);
        Vector3 spawnPos = new Vector3(xPos, enemyPrefab.transform.position.y, zPos);
        return spawnPos;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
