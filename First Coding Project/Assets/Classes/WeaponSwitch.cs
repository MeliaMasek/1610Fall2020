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
    LongSword,
    Mace,
    Scythe,
    Shield,
    Rapier,
    CrossBow,
}

public WeaponClasses currentWeaponClasses = WeaponClasses.LongSword;

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
        case WeaponClasses.LongSword:
            // equips LongSword
            break;
        case WeaponClasses.Mace:
            // equips Mace
            break;
        case WeaponClasses.Scythe:
            //equips Scythe
            break;
        case WeaponClasses.Shield:
            // equips Shield
            break;
        case WeaponClasses.Rapier:
            // equips Rapier
            break;
        case WeaponClasses.CrossBow:
            // equips CrossBow
            break;
        default:
            throw new ArgumentOutOfRangeException();
        }
    }
}
