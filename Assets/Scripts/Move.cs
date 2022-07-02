using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -4)
        {
            transform.Translate(0, 0, 0.1f);
        }
        else if (transform.position.x > 4)
        {
            transform.Translate(0, 0, -0.1f);
        }
    }
}
