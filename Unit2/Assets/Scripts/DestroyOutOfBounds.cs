using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
   
   //set bounderies
    public float topBound = 30;
    public float lowerbound = -10;
    void Start()
    {
        
    }

    
    void Update()
    {	
    	// if object goes past players remove them
        if (transform.position.z > topBound) {
        	Destroy(gameObject);
        } else if (transform.position.z < lowerbound) {
        	Debug.Log("Game over!");
        	Destroy(gameObject);
        }
    }
}
