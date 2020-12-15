using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMananger : MonoBehaviour

{
    public GameObject[] coinPrefab;
    private float spawnRangeX = 38.4f;
    private float spawnPosZ = -0.87f;
    private float spawnPosy = 10.8f;
    //private float startDelay = 2f;
    //private float spawnInterval = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
InvokeRepeating("spawnRandomCoin", 1, 1.5f);    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void spawnRandomCoin()
    { 
         Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX),0, spawnPosZ);
            int coinIndex = Random.Range(0, coinPrefab.Length);
            Instantiate(coinPrefab[coinIndex], spawnPos,
                coinPrefab[coinIndex].transform.rotation);
        }
}
