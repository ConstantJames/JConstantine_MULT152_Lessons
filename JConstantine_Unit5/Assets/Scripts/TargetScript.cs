using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetScript : MonoBehaviour
{

    private const float minForce = 10;
    private const float maxForce = 15;
    private const float minTorque = -10;
    private const float maxTorque = 10;
    private const float minXPos = -3;
    private const float maxXPos = 3;
    private const float ySpawnPos = 2;
    private GameManager gameManager;
    private Rigidbody targetRB;

    public int pointValue;
    public ParticleSystem expParticle;
    // Start is called before the first frame update
    void Start()
    {
        targetRB = GetComponent<Rigidbody>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        RandomForce();
        RandomTorque();
        RandomSpawnPos();
    }

    void RandomForce()
    {
        targetRB.AddForce(Vector3.up * Random.Range(minForce, maxForce), ForceMode.Impulse);
    }

    void RandomTorque()
    {
        targetRB.AddTorque(Random.Range(minTorque, maxTorque),
        Random.Range(minTorque, maxTorque),
        Random.Range(minTorque, maxTorque), ForceMode.Impulse);
    }
    
    void RandomSpawnPos()
    {
        transform.position = new Vector3(Random.Range(minXPos, maxXPos), ySpawnPos);
    }


    private void OnMouseDown()
    {
        gameManager.UpdateScore(pointValue);
        Instantiate(expParticle, transform.position, expParticle.transform.rotation);
        Destroy(gameObject);
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
