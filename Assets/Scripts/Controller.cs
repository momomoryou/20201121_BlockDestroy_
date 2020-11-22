using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float spead = 0.2f;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += transform.forward * spead;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position -= transform.forward * spead;
        }
    }
}