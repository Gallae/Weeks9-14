using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frog : FormAnimals
{

    public enum Form
    {
        egg, tadpole, frog
    }

    public Form currentForm = Form.egg;
    public float timeInForm = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        FormUpdate();
    }
}
