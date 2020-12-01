using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsX : MonoBehaviour
{
    private float leftLimit = -50;
    private float bottomLimit = -1;

    // Update is called once per frame
    void Update()
    {   
        // if object goes past players remove them
        if (transform.position.x < leftLimit) {
            Destroy(gameObject);
        } else if (transform.position.y < bottomLimit) {
            
            Destroy(gameObject);
        }
    }
}
