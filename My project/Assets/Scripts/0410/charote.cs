using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charote: MonoBehaviour
{

    float rotSpeed = 0;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            this.rotSpeed = 10000;
        }

        transform.Rotate(0, this.rotSpeed * Time.deltaTime, 0);

        rotSpeed *= 0.99f;
    }
}
