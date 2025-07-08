using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chaser : MonoBehaviour
{

    public Camera gamecam;
  
         public Vector3 newposition;

    public float speed;
    bool ifmouseIsPressed;

    // Start is called before the first frame update
    void Start()
    {
        ///transform.position = newposition;

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 Mousepositioninworldspace = gamecam.ScreenToWorldPoint(Input.mousePosition);
         Mousepositioninworldspace.z = 0f;

        Vector3 start = transform.position;
        Vector3 target = Mousepositioninworldspace;
        //in strad if input.mouse becasue we want in world space or it throws around
        Vector3 directiontomove = target - start;

;
        bool ifRightIsPressed = Input.GetMouseButton(0); 

        if (ifRightIsPressed == true)
        {
            transform.position = transform.position + directiontomove * speed;
        }
    }
}
