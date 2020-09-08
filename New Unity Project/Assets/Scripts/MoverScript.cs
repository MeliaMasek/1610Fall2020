using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;

public class MoverScript : MonoBehaviour
{
    public float x, y, z;
    public float speed = 3f;
    public int score = 100;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(message: "Hello World");
    }

    // Update is called once per frame
    void Update()
    {
        x = speed*Input.GetAxis("Horizontal") * Time.deltaTime;
        y = speed*Input.GetAxis("Vertical") * Time.deltaTime;
        transform.Translate(x, y, z);
    }
}
