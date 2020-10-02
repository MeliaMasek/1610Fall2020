using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewMoverScript : MonoBehaviour
{
    public float moveSpeed;

    private Vector3 moveDirection;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Jump"))
        {
            moveDirection.x = moveSpeed * Time.deltaTime;
        }
        else
        {
            moveDirection.x = -moveSpeed * Time.deltaTime;
        }
        transform.Translate(moveDirection);
    }
}