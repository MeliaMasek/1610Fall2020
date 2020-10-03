using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsX : MonoBehaviour
{
   //start is called before the first frame update
   void Start()
   {
       
   }

    // Update is called once per frame
    private float topbound = 50;
    private float lowerbound = -50;
    void Update()
    {
        // Destroy dogs if x position less than left limit
        if (transform.position.z > topbound)
        {
            Destroy(gameObject);
        } 
        // Destroy balls if y position is less than bottomLimit
        else if (transform.position.z < lowerbound)
        {
            Destroy(gameObject);
        }

    }
}
