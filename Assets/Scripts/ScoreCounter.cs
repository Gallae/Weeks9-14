using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    public Text score;

    private void Update()
    {
        score = transform.GetComponent<Text>();
    }
}
