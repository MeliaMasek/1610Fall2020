using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fighter : Player
{
    public float superiorityDice = 1f;

    private void Start()
    {
        perception = 100;
    }
    protected void ActionSurge()
    {
        var use = superiorityDice;
    }
}
