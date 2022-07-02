using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script1 : MonoBehaviour
{
    public float f = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -3.5)
        {
            f = -0.1f;
        }
        if (transform.position.x > 3.5)
        {
            f = 0.1f;
        }
        transform.Translate(f/100, 0, 0);
    }
}
