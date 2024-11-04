using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody rbPlayer;
    GameObject focalPoint;
    Renderer rendererPlayer;
    public float speed = 10.0f;
    public float powerupSpeed = 10.0f;
    public GameObject powerupInd;

    public bool hasPowerup = false;
    
    // Start is called before the first frame update
    void Start()
    {
        rbPlayer = GetComponent<Rigidbody>();
        rendererPlayer = GetComponent<Renderer>();
        focalPoint = GameObject.Find("Focal Point");
    }

    // Update is called once per frame
    void Update()
    {
        float forwardInput = Input.GetAxis("Vertical");
        float magnitude = forwardInput * speed * Time.deltaTime;
        rbPlayer.AddForce(focalPoint.transform.forward * magnitude, ForceMode.Force);

        if (forwardInput > 0)
        {
            rendererPlayer.material.color = new Color(1.0f - forwardInput, 1.0f, 1.0f - forwardInput);
        }
        else
        {
            rendererPlayer.material.color = new Color(1.0f + forwardInput, 1.0f, 1.0f + forwardInput);
        }
        powerupInd.transform.position = transform.position;
    }
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Powerup"))
            {
               
            hasPowerup = true;
            Destroy(other.gameObject);
            StartCoroutine(PowerupCountdown());
            powerupInd.SetActive(true);
            }


        }

    private void OnCollisionEnter(Collision collision)
    {
        if (hasPowerup && collision.gameObject.CompareTag("Enemy")) 
        {
            Debug.Log("Player has collided with" + collision.gameObject + " with powerup set to: " + hasPowerup);
            Rigidbody rbEnemy = collision.gameObject.GetComponent<Rigidbody>();
            Vector3 awayDir = collision.gameObject.transform.position - transform.position;

            rbEnemy.AddForce(awayDir * powerupSpeed, ForceMode.Impulse);

        }
    }

    IEnumerator PowerupCountdown()
    {
        yield return new WaitForSeconds(8);
        hasPowerup = false;
        powerupInd.SetActive(false);
    }

}
