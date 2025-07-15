using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tankmove : MonoBehaviour
{
    bool right;
        bool left;
    bool up;
    bool down;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newLPos = transform.position + Vector3.right * -0.001f;

        Vector3 newRPos = transform.position + Vector3.right * 0.001f;

        Vector3 newUPos = transform.position + Vector3.up * 0.001f;

        Vector3 newDPos = transform.position + Vector3.up * -0.001f;

        bool right = Input.GetKey(KeyCode.D);
        bool down = Input.GetKey(KeyCode.S);
        bool up = Input.GetKey(KeyCode.W);
        bool left = Input.GetKey(KeyCode.A);

        if (right == true)
        {
            transform.position = newRPos;
        }

        if (down == true)
        {
            transform.position = newDPos;
        }

        if (up == true)
        {
            transform.position = newUPos;
        }

        if (left == true)
        {
            transform.position = newLPos;
        }
    }
}
