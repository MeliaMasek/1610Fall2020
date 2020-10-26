using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateWithCode : MonoBehaviour
{
    public BoolData gameOverData;

    private void OnTriggerEnter(Collider other)
    {
        gameOverData.value = true;
        print("Game Over");
    }
}
