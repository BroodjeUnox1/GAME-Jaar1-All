using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float dogBound = -50;
    public float ballBound = -10;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {	
    	// if object goes past players remove them
        if (transform.position.z < dogBound) {
        	Destroy(gameObject);
        } else if (transform.position.y < ballBound) {
        	Destroy(gameObject);
        }
    }
}
