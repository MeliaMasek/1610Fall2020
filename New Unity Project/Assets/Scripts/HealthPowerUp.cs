using UnityEngine;

public class HealthPowerUp : MonoBehaviour
{
    public int health;
    private void OnTriggerEnter(Collider other)
    {
        health++;
        print(health);
    }
}