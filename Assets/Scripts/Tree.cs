using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour
{
    public AnimationCurve curve;
    public float duration;
    public Transform appleTransform;
    public List<Transform> appleList = new List<Transform>();

    public float currentTime = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartGrow()
    {
        currentTime = 0;
        StartCoroutine(Grow());
    }

    public IEnumerator Grow()
    {
        while (currentTime < duration)
        {
            currentTime += Time.deltaTime;

            float timeRatio = currentTime / duration;

            transform.localScale = Vector3.one * curve.Evaluate(timeRatio);
            
            yield return null;
        }

        currentTime = 0f;

        int i = 0;
        while (currentTime < duration && i < appleList.Count)
        {
            currentTime += Time.deltaTime;

            float sizeRatio = Random.Range(0.1f, 2f);
            float timeRatio = currentTime / duration;

            appleList[i].transform.localScale = (Vector3.one*sizeRatio) * curve.Evaluate(timeRatio);

            if(currentTime >= duration)
            {
                i++;
                currentTime = 0;
            }

            // appleTransform.localScale = Vector3.one * curve.Evaluate(timeRatio);

            yield return null;
        }
    }
}
