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
        //check to see if the boxer is already winding up a punch
        if (!punching)
        {
            //loop through every 2 seconds (determined by countdown on line 10)
            if (t < countdown)
            {
                t += Time.deltaTime;
            }
            //choose one of the two fists at random, then begin the Punch() coroutine
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
        //set the colour of the randomly-chosen fist to cyan, then wait 1 second
        if (punching)
        {
            fists[punchingFist].gameObject.GetComponent<SpriteRenderer>().color = Color.cyan;
            thumbs[punchingFist].gameObject.GetComponent<SpriteRenderer>().color = Color.cyan;
        }
        pointGained = false;
        yield return new WaitForSeconds(1f);
        //set "punching" back to false and set fist back to red, then yield
        punching = false;
        fists[punchingFist].gameObject.GetComponent<SpriteRenderer>().color = Color.red;
        thumbs[punchingFist].gameObject.GetComponent<SpriteRenderer>().color = Color.red;
        yield return null;
    }

    public void BlockChance(int buttonToClick)
    {
        //check if the int being passed into this function from the inspector matches the random number
        if (buttonToClick == punchingFist)
        {
            //stops the player from getting more than one point per punch blocked
            if(pointGained==false)
            {
                //increases score by 1, updates the score counter, ends the Punch() coroutine early
                score += 1;
                pointGained=true;
                scoreCounter.text = score.ToString();
                StopCoroutine("Punch");
            }

        }
    }
}
