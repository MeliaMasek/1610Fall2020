using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCash : MonoBehaviour
{
    public IntData cashTotal;

    private void OnTriggerEnter(Collider other)
    {
        cashTotal.value = 100;
        gameObject.SetActive(false);
    }
}
