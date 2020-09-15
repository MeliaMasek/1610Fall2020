using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public float speed = 20;
    public float turnSpeed;
    public float horizontalInput;
    public float forwardInput;
    
    void Update()
    {
        // Move the vehicle forward
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        //Moves the car forward based on vertical input
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput*Time.deltaTime);
        // rotates the car based on horizontal input
        transform.Translate(Vector3.forward * Time.deltaTime*speed* forwardInput);
        //transform.Translate(Vector3.right * Time.deltaTime* turnSpeed* horizontalInput);
    }
}
