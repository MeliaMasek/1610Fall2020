using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class AddForce : MonoBehaviour
{
    private Rigidbody rigid;
    public Vector3 forces, forces2;
    public float holdTime = 3f;
    public int counter = 10;
    public bool canRun;
    private IEnumerable Start()
    {
        rigid = GetComponent<Rigidbody>();

        while (counter > 0)
        {
            yield return new WaitForSeconds(holdTime);
            rigid.AddForce(forces);
            counter--;
        }

        while (canRun)
        {
            yield return new WaitForSeconds(holdTime);
            rigid.AddForce(forces2);
        }
    }
}
