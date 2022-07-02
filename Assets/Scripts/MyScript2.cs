using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScript2 : MonoBehaviour
{
    float f=0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > 2)
        {
            f = -0.01f;
        }
        if (transform.position.y<0)
        {
            f = 0.01f;
        }
        transform.Translate(0, f, 0);
    }
}
