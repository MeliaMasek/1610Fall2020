using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class MonoEvents : MonoBehaviour
{
  public UnityEvent awakeEvent, startEvent, onEnableEvent;

  public void Awake()
  {
    awakeEvent.Invoke();
  }
  private void Start()
  {
    startEvent.Invoke();
  }

  private void OnEnable()
  {
    onEnableEvent.Invoke();
  }
}
