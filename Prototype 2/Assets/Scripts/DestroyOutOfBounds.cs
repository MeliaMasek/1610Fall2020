using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
 private void OnTriggerEnter(Collider other)
 {
  Destroy(other.gameObject);
 }

 private void OnCollisionEnter(Collision other)
 {
  Destroy(other.gameObject);
  print("hit");
  
 }
}
