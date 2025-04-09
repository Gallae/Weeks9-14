using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyMovement : MonoBehaviour
{
    public AnimationCurve curve;
    private float curveEnd = 0.2f;

    public float t;

    private void Update()
    {
        t += Time.deltaTime;

        transform.position = Vector2.up * curveEnd * curve.Evaluate(t);

        if(t > 1)
        {
            t = 0;
        }
    }

}
