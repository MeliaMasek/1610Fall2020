﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public float startDelay = 2;
    public float repeatRate = 2;
    private Vector3 spawnPos = new Vector3(25, 0 , 0 );
   // Start is called before the first frame update
    void Start()
    {
    InvokeRepeating("SpawnObstacle", startDelay, repeatRate);    }

    // Update is called once per frame
    void Update()
    {
        Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
    }
}
