using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script2 : MonoBehaviour
{
    float f = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z < 44)
        {
            f = -0.1f;
        }
        if (transform.position.z > 54)
        {
            f = 0.1f;
        }
        transform.Translate(0, 0, f / 100);
    }
}
