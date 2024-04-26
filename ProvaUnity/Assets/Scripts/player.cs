using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetAxisRaw("Horizontal") > 0) && (transform.position.x < 11.39))
        {
            transform.Translate(0.03f, 0, 0);
        }
        else if ((Input.GetAxisRaw("Horizontal") < 0) && (transform.position.x > -11.38))
        {
            transform.Translate(-0.03f, 0, 0);
        }
    }
}
