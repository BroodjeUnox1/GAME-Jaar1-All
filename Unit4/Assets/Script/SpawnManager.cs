﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
	private	float spawnRange = 9.0f;					
	public GameObject enemyPrefab;
	public GameObject PowerupPrefab;
	public int enemyCount;
	private int waveNumber = 1;
    // Start is called before the first frame update
    void Start()
    {
    	SpawnEnemyWave(waveNumber);
        Instantiate(PowerupPrefab, GenerateSpawnPosition(), PowerupPrefab.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        enemyCount = FindObjectsOfType<Enemy>().Length;

        if(enemyCount == 0) {
        	waveNumber++;
        	SpawnEnemyWave(waveNumber);
        	Instantiate(PowerupPrefab, GenerateSpawnPosition(), PowerupPrefab.transform.rotation);
        }
    }

    void SpawnEnemyWave(int enemiesToSpawn) {
    	for (int i=0; i<enemiesToSpawn; i++) {
    		Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation);
    	}
    }

    private Vector3 GenerateSpawnPosition() {
    	float spawnPosX = Random.Range(-spawnRange, spawnRange);
    	float spawnPosZ = Random.Range(-spawnRange, spawnRange);

    	Vector3 randomPos =new Vector3(spawnPosX, 0, spawnPosZ);
    	return randomPos;
    }
}
