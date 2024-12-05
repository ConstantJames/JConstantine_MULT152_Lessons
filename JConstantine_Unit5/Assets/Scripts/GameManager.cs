using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

   
    public List<GameObject> prefabs;
    private const float spawnRate = 2.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnTarget());
    }


    IEnumerator SpawnTarget()
    {

        while (true)
        {
            yield return new WaitForSeconds(spawnRate);
            Instantiate(prefabs[Random.Range(0, prefabs.Count)]);
        }


    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
