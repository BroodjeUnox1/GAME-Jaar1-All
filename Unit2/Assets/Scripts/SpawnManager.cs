using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Start is called before the first frame update
    //makes an array of the animals
    public GameObject[] animalPrefabs;
    // for cleaner code in randomspawnpos
    private float spawnRangex = 15;
    //for cleaner code in randomspawnpos
    private float spawnRangez = 20;
    //set our start delay
    private float startDelay = 2;
    //set our interval
    private float spawnInterval = 1.5f;


    void Start()
    {//spawn animals
      InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);  
    }

    void Update()
    {	

    }

    void SpawnRandomAnimal() 
    {	//random int for our array selector
    	int animalIndex = Random.Range(0, animalPrefabs.Length);
        // ranom spawnpos between -20 z and 20 z
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangex, spawnRangex), 0, spawnRangez);
        //clone animal from prefab
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
