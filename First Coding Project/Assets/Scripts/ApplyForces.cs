using UnityEngine;

public class ApplyForces : MonoBehaviour
{
   
    public Rigidbody rBody;
    public float force = 30f;
    
    // Start is called before the first frame update
    void OnMouseDown()
    {
        rBody.AddForce(0, force, 0);
    }
}
