using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectCash : MonoBehaviour
{
    public IntData cashTotal;
    public Collectible collectibleobj;
    public Text txtObj;
    private SpriteRenderer renderer;
    
    private void Start()
    {
        renderer = GetComponent<SpriteRenderer>();
        renderer.sprite = collectibleobj.art;
        renderer.color = collectibleobj.artColor;
        txtObj.text = cashTotal.value.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        cashTotal.value += collectibleobj.cashValue;
        txtObj.text = cashTotal.value.ToString();
        gameObject.SetActive(false);
    }
}
