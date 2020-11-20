using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
public class CountDown : MonoBehaviour
{
    public UnityEvent startEvent, endEvent;
    public float holdTime = 1f; //repeatHoldTime = .25f;
    public int counter = 3;
    public bool ison;
    public void RunCoroutine()
    {
        StartCoroutine(Coroutine());
    }
    
    private IEnumerator Coroutine()
    {
        startEvent.Invoke();
        yield return new WaitForSeconds(holdTime);

        //while (counter > 0)
        {
            //repeatEvent.Invoke();
            //yield return new WaitForSeconds(repeatHoldTime);
            ////counter--;
        }
        yield return new WaitForSeconds(holdTime);
        endEvent.Invoke();
    }
}
