﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    private int randomInt;
    private float spawnIntervalStart = 3.0f;
    private float spawnIntervalEnd = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomBall", startDelay, Random.Range(spawnIntervalStart, spawnIntervalEnd));
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        

        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[randomInt], spawnPos, ballPrefabs[0].transform.rotation);
    }

}
