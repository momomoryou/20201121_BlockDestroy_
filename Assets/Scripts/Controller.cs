using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float moveRange = 0.1f;
    public float spead = 0.2f;

    void Start()
    {
       //Debug.Log(moveRange);

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(
            transform.position.x,
            transform.position.y,
            Mathf.Clamp(transform.position.z, -moveRange,moveRange));

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