using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class JumpInputAnimation : MonoBehaviour
{
    private Animator anims;

    private void Start()
    {
        anims = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump"))

        {
            anims.SetTrigger("Jump");
        }
    }
}