using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hourhandrotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 hourhand = transform.eulerAngles;
        hourhand.z += -0.01f;
        transform.eulerAngles = hourhand;
    }
}
