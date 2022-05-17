using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Vector3 Speed;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //transform.position += Speed;
        if (transform.position.x < 10)
        {
            transform.position += Speed;

        }
    }
}
