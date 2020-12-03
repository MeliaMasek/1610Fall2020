using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
public class NumberCountdown : MonoBehaviour
{
    private Text textobj;
    public float delay = 1f;
    public UnityEvent goEvent;
    IEnumerator Start()
    {
        textobj = GetComponent<Text>();
        textobj.text = "3";
        var i = 3;
        while (i > 0)
        {
            textobj.text = i.ToString();
            yield return new WaitForSeconds(delay);
            i--;
        }

        textobj.text = "Go!";
        yield return new WaitForSeconds(delay);
        textobj.text = " ";
        goEvent.Invoke();
    }
}