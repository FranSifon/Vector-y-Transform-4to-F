using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vector3Script : MonoBehaviour
{
    public Vector3 miVector;
    public GameObject myObject;

    void Start()
    {
        myObject.transform.position = miVector;
    }

    void Update()
    {
        
    }
}
