using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{

    public float topOfScene = 30.0f;
    public float bottomOfScene = -10.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (transform.position.z > topOfScene)
        {
            Destroy(gameObject);
        }

        else if (transform.position.z < bottomOfScene)
        {
            Destroy(gameObject);
        }
    }
}
