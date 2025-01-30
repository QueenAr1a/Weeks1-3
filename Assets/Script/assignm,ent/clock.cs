using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clock : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
        //the aply named clock is actually a fan
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //no set of variables or anything just bvasically right into the work
        //vector 3 set it to 3d and then transfor euler (basicaly just rotate) rotates it along the z at a speed of +2
       Vector3 rot = transform.eulerAngles;
        rot.z = +2;
        transform.eulerAngles += rot;   
    }
}
