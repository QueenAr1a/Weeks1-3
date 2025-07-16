using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTriangle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // easy code to rotate the blades super simple
        Vector3 rotato = transform.eulerAngles;
        //gives a V3 to work with to actually roatate it with euler
        rotato.z += -2;
        //set the rotation speed
        transform.eulerAngles = rotato;
        //and just sets the transform to the stuff above
    }
}
