using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public float startDelay = 2f;
    public float repeatRate = 2f;
    private PlayerController playerControllerScript;
    private Vector3 spawnPos = new Vector3(25, 0 , 0 );
   // Start is called before the first frame update
   private void Start()
   {
       InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
       playerControllerScript =
           GameObject.Find("Player").GetComponent<PlayerController>();
   }
   void SpawnObstacle()
   {
//       if (playerControllerScript.gameOver == false)
       {Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);}
   }
}
