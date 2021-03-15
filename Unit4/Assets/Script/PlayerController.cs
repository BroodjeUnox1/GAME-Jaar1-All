using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public float speed = 5.0f;
	private Rigidbody playerRB;
	private float powerUpStrength = 10.0f;
	private GameObject focalPoint;
	public bool  hasPowerup = false;
	public GameObject powerupIndicator;
    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("FocalPoint");
    }

    // Update is called once per frame
    void Update()
    {
        float forwardInput = Input.GetAxis("Vertical");
        powerupIndicator.transform.position = transform.position + new Vector3(0, 1, 0);
        playerRB.AddForce(focalPoint.transform.forward * forwardInput * speed);
    }

    private void OnTriggerEnter(Collider other) {
    	if(other.CompareTag("Powerup")) {
    		Destroy(other.gameObject);
    		hasPowerup = true;
    		StartCoroutine(PowerupCountdownRoutine());
    		powerupIndicator.gameObject.SetActive(true);
    	}
    }

    IEnumerator PowerupCountdownRoutine() {
    	yield return new WaitForSeconds(7);
    	hasPowerup = false;
    	powerupIndicator.gameObject.SetActive(false);
    }

    private void OnCollisionEnter(Collision collision)
	{
	     if (collision.gameObject.CompareTag("Enemy") && hasPowerup)
	     {
	     	Rigidbody enemyRigidbody = collision.gameObject.GetComponent<Rigidbody>();
	     	Vector3 awayFromPlayer = collision.gameObject.transform.position - transform.position;
	     	enemyRigidbody.AddForce(awayFromPlayer * powerUpStrength, ForceMode.Impulse);
	        Debug.Log("Collided with: " + collision.gameObject.name + " with powerup set to " + hasPowerup);
	     }
	}
}
