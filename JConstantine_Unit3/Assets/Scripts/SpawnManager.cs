using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject obsPrefab;
    private Vector3 spawnPos = new Vector3(30, 0, 0);

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObs", 2, 2);
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObs()
    {
        Instantiate(obsPrefab, spawnPos, obsPrefab.transform.rotation);
    }
}
