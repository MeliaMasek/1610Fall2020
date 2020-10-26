using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]

public class CharacterMover : MonoBehaviour
{
    private CharacterController controller;
    public float moveSpeed = 3f, gravity = -9.81f, jumpForce = 30f;
    
    private Vector3 moveDirection;
    private float yDirection;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        var moveSpeedInput = moveSpeed * Input.GetAxis("Horizontal");
        moveDirection.Set(moveSpeedInput,yDirection,0);       
        yDirection += gravity*Time.deltaTime;

        if (controller.isGrounded && moveDirection.y < 0)
        {
            yDirection = -1f;
        }
        
        if (Input.GetButtonDown("Jump"))
        {
            yDirection = jumpForce;
        }
        controller.Move(moveDirection*Time.deltaTime);
    }
}
