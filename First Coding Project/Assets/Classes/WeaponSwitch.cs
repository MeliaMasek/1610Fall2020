using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class WeaponSwitch : ScriptableObject
{
public enum WeaponClasses
{
    Axe,
    Hammer, 
    Spear,
    Bow,
    Sword,
}

public WeaponClasses currentWeaponClasses = WeaponClasses.Sword;

public void ChangeToBow()
{
    currentWeaponClasses = WeaponClasses.Bow;
}

public void RunCurrentState()
    {
    switch (currentWeaponClasses)
        {
        case WeaponClasses.Axe:
            // equips Axe    
            break;
        case WeaponClasses.Hammer: 
            // equips Hammer 
            break;
        case WeaponClasses.Spear:
            // equips Spear 
            break;
        case WeaponClasses.Bow:
            // equips Bow 
            break;
        case WeaponClasses.Sword:
            // equips Sword
            break;
        default:
            throw new ArgumentOutOfRangeException();
        }
    }
}
