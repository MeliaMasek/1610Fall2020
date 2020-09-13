using UnityEngine;

public class ManaPowerUp : MonoBehaviour
{
    public int mana;
    private void OnTriggerEnter(Collider other)
    {
        mana++;
        print(mana);
    }
}
