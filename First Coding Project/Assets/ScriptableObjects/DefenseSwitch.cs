using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class DefenseSwitch : ScriptableObject
{
  public enum Defences
  {
    Shield,
    Potions,
    ExtraHealth,
    Buffs,
    SuperShield,
    Armor,
    SuperArmor,
  }

  public Defences currentDefence;

  public void RunCurrentDefence()
  {
    switch (currentDefence)
    {
      case Defences.Shield:
        break;
      case Defences.Potions:
        break;
      case Defences.ExtraHealth:
        break;
      case Defences.Buffs:
        break;
      case Defences.SuperShield:
        break;
      case Defences.Armor:
        break;
      case Defences.SuperArmor:
        break;
      default:
        throw new ArgumentOutOfRangeException();
    }
  }
}
