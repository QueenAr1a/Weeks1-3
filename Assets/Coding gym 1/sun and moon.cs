using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class sunandmoon : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 snm = transform.eulerAngles;
        snm.z += -0.005f;
        transform.eulerAngles = snm;
    }
}
