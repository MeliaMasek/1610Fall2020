using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float health = 100f;
    public int Points = 100;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Player Health");
    }
    // Update is called once per frame
    void Update()
    {
        health = 100f;
    }
}
