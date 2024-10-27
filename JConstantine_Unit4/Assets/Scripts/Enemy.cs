using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    Rigidbody enemyRB;
    GameObject player;
    public float speed = 4.0f;

    // Start is called before the first frame update
    void Start()
    {
        enemyRB = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 seekDirection = (player.transform.position - transform.position).normalized;
        enemyRB.AddForce( seekDirection * speed * Time.deltaTime);
    }
}
