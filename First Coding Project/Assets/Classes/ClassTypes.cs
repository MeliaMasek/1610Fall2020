using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassTypes : MonoBehaviour
{
    public List<Classes> classList;
    public List<WeaponSwitch> WeaponSwitch;
    private void Start()
    {
        for (var i = 0; i < classList.Count; i++)
        {
            var position = new Vector3(i * 2, 0, 0);
            var item = classList[i];
            var newItem = new GameObject(item.name);
            var sprite = newItem.AddComponent<SpriteRenderer>();

            newItem.transform.position = position;

            sprite.sprite = item.art;
            sprite.color = item.color;
        }

        foreach (var item in classList)
        {
            print(classList[0] + classList[0].role);
            print(classList[1] + classList[1].role);
            print(classList[2] + classList[2].role);
            print(classList[3] + classList[3].role);
        }
    }
}
