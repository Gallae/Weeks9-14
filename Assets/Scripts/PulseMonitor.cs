using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PulseMonitor : MonoBehaviour
{
    float speed = 0.01f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 dotpos = transform.position;
        dotpos.x += speed;
        Vector2 screenpos = Camera.main.WorldToScreenPoint(dotpos);
        if (screenpos.x >= Screen.width);
        {
            screenpos.x = 0;
        }

        transform.position = dotpos;
    }
}
