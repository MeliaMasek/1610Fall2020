using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class WeaponSwitch : ScriptableObject
{
    public Color color;
    public enum WeaponClasses
{
    Axe,
    Hammer, 
    Spear,
    Bow,
    LongSword,
    Dagger,
    Scythe,
    Shield,
    Rapier,
    Staff, 
    Tome, 
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
            // Specific to  
            break;
        case WeaponClasses.Hammer: 
            // equips Hammer 
            // Specific to
            break;
        case WeaponClasses.Spear:
            // equips Spear 
            // Specific to 
            break;
        case WeaponClasses.Bow:
            // equips Bow 
            // Specific to Ranger
            break;
        case WeaponClasses.LongSword:
            // equips LongSword
            // Specific to Warrior and Tank 
            break;
        case WeaponClasses.Dagger:
            // equips Dagger
            // Specific to Ranger and Thief
            break;
        case WeaponClasses.Scythe:
            //equips Scythe
            // Specific to 
            break;
        case WeaponClasses.Shield:
            // equips Shield
            // Specific to Tank
            break;
        case WeaponClasses.Rapier:
            // equips Rapier
            // Specific to Warrior 
            break;
        case WeaponClasses.Staff:
            // equips Staff
            // Specific to Wizard and Healer  
            break;
        case WeaponClasses.Tome:
            // equips Tome
            // Specific to Healer
            break;
        default:
            throw new ArgumentOutOfRangeException();
        }
    }
}
