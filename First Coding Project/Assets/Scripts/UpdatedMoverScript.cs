using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdatedMoverScript : MonoBehaviour
{
    public float speed = 10f;
    public Vector3 rotationVector3;
    public string password;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        if (password == "OU812" )
        {
            print("Password Correct");
        }
        rotationVector3.y = speed * Time.deltaTime;
        transform.Rotate(rotationVector3);
    }
}
