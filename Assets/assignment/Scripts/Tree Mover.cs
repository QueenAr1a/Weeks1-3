using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeMover : MonoBehaviour
{
    public float speed;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.right * speed;
        Vector3 TreeposinScreen = Camera.main.WorldToScreenPoint(transform.position);

        if (TreeposinScreen.x > 360)
        {
            speed = 0;
        }
    }
}
