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

    public void Up()
    {
        print("Up");
        transform.Translate(x:0, y:speed, z:0);
    }
    public void Down()
    {
        print("Down");
        transform.Translate(x:0, y:-speed, z:0);
    }
    public void Left()
    {
        print("Left");
        transform.Translate(x:-speed, y:0, z:0);
    }
    public void Right()
    {
        print("Right");
        transform.Translate(x:speed, y:0, z:0);
    }
}
