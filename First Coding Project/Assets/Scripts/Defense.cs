using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class Defense : Collectible
{
    public float PowerLevel = .5f;

    public void Use()
    {
     Debug.Log(this.name);   
    }
}
