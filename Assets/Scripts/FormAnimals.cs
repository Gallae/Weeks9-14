using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FormAnimals : MonoBehaviour
{
    public float formDuration = 4f;
    private float timeInForm = 0f;

    private void ChangeForm()
    {

    }

    public void FormUpdate()
    {
        timeInForm += Time.deltaTime;
        if (timeInForm > formDuration)
        {
            ChangeForm();
        }
    }
}
