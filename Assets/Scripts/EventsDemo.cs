using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventsDemo : MonoBehaviour
{
    public RectTransform banana;

    public UnityEvent onTimeUp;
    public float timerLength = 2;
    public float t;

    private void Update()
    {
        t += Time.deltaTime;
        if (t > timerLength)
        {
            onTimeUp.Invoke();
            t = 0;
        }
        //if (t < timerLength)
        //{
        //    t += Time.deltaTime;
        //}
        //else
        //{
        //    onTimeUp.Invoke();
        //}
    }
    public void MouseJustEntered()
    {
        banana.localScale = Vector3.one * 1.2f;
        Debug.Log("Mouse just entered me!");
    }

    public void MouseJustExited()
    {
        banana.localScale = Vector3.one;
        Debug.Log("Mouse just exited me!");
    }
}
