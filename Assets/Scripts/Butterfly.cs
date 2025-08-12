using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Butterfly : MonoBehaviour
{
    public enum Form
    {
        caterpillar, coccoon, butterfly
    }

    public Form currentForm = Form.caterpillar;

    public float formDuration = 4f;

    private float timeInForm = 0f;

    public ParticleSystem butterflyParticles;

    public Gradient coccoonGradient, butterflyGradient;

    private ParticleSystem.MainModule butterflyModule;

	private void Start()
	{
        butterflyModule = butterflyParticles.main;
	}

	// Update is called once per frame
	void Update()
    {
        FormUpdate();
    }

    void FormUpdate()
    {
        timeInForm += Time.deltaTime;
        if (timeInForm > formDuration)
        {
            ChangeForm();
        }
    }

    void ChangeForm()
    {
        if (currentForm == Form.caterpillar)
        {
            timeInForm = 0f;
            currentForm = Form.coccoon;
            Debug.Log("Changing form to Cocoon");
            butterflyModule.startColor = coccoonGradient;
        }
        else if (currentForm == Form.coccoon)
        {
            timeInForm = 0f;
            currentForm = Form.butterfly;
            Debug.Log("Changing form to Butterfly");
            butterflyModule.startColor = butterflyGradient;
        }
    }
}
