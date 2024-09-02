using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Sets speed of vehicle
    private float speed = 15.0f;
    private float turnSpeed = 45.0f;

    // Sets player inputs
    private float horizontalInput;
    private float verticalInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       // Makes player input work
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

       // Vehicle Forward/Backwards
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput );
       // Vehicle Turn
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);

    }
}
