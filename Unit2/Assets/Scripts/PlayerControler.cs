using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{   

    // al bounderies set
	public GameObject projectilePrefab;
	public float horizontalInput;
	public float speed = 20.0f;
	public float xRange = 15;
	public float topBound = 30f;

    void Start()
    {
        
    }

    void Update()
    {   // doesnt let the player go out of the field and shoot the food
    	if (transform.position.x < -xRange) {
    		transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
    	} 

    	if (transform.position.x > xRange) {
    		transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
    	} 

    	if (Input.GetKeyDown(KeyCode.Space)) {
    		Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
    	}

        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
    }
}

