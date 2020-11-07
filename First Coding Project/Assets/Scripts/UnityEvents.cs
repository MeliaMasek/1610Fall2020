using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class UnityEvents : MonoBehaviour
{
   public UnityEvent triggerExitEvent;
   public UnityEvents triggerStayEvent;
   public UnityEvents awakeEvent; 
   
   public UnityEvent myUnityEvent;

    private void OnTriggerEnter(Collider other)
    {
       myUnityEvent.Invoke();
    }
   private void OnTriggerExit(Collider other)
   {
      triggerExitEvent.Invoke();
   }

   private void OnTriggerStay(Collider other)
   {
      triggerStayEvent.Invoke(null, 0);
   }
   private void Awake()
   {
      awakeEvent.Invoke(null, 0);
   }
}
