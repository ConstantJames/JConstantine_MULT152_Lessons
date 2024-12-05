using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{

   
    public List<GameObject> prefabs;
    private const float spawnRate = 2.0f;

    public TextMeshProUGUI scoreText;
    private int score = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnTarget());
        UpdateScore(0);
    }


    IEnumerator SpawnTarget()
    {

        while (true)
        {
            yield return new WaitForSeconds(spawnRate);
            Instantiate(prefabs[Random.Range(0, prefabs.Count)]);
        }


    }

    public void UpdateScore(int scoreDelta)
    {
        score += scoreDelta;
        if (score < 0) 
        {
            score = 0;        
        }
        scoreText.text = "Score: " + score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
