using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PunchBehavior : MonoBehaviour
{
    private float countdown = 2;
    public float t;
    public int punchingFist;
    public Button blockRightPunch;
    public Button blockLeftPunch;
    public GameObject[] fists = new GameObject[2];
    public GameObject[] thumbs = new GameObject[2];
    public Button[] buttons = new Button[2];
    public bool punching;
    public bool pointGained;
    public TextMeshProUGUI scoreCounter;
    public int score;

    private void Update()
    {
        if (!punching)
        {
            if (t < countdown)
            {
                t += Time.deltaTime;
            }
            else
            {
                t = 0;
                punchingFist = Random.Range(0, 2);
                StartCoroutine(Punch());
            }
        }
        
    }

    public IEnumerator Punch()
    {
        Debug.Log("Punch starting!!");
        punching = true;
        if (punching)
        {
            fists[punchingFist].gameObject.GetComponent<SpriteRenderer>().color = Color.cyan;
            thumbs[punchingFist].gameObject.GetComponent<SpriteRenderer>().color = Color.cyan;
        }
        pointGained = false;
        yield return new WaitForSeconds(1f);
        punching = false;
        fists[punchingFist].gameObject.GetComponent<SpriteRenderer>().color = Color.red;
        thumbs[punchingFist].gameObject.GetComponent<SpriteRenderer>().color = Color.red;
        yield return null;
    }

    public void BlockChance(int buttonToClick)
    {
        if (buttonToClick == punchingFist)
        {
            if(pointGained==false)
            {
                score += 1;
                pointGained=true;
                scoreCounter.text = score.ToString();
                StopCoroutine("Punch");
            }

        }
    }
}
