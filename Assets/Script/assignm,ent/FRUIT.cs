using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class FRUIT : MonoBehaviour

{
    // Start is called before the first frame update
    //this code is for the fruit. when the mouse is held the fruit will follow
    void Start()
    {
        
    }

    // Update is called once per frame
    
    void Update()
    {
        // starting with setting up the mouse position, making it a vector 2 so it stays on screen and world point to keep it in the frame
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        // this just tells if the mouse is pressed
        if (Input.GetMouseButton(0))
        {
            //this moves the fruit to the mouse postion
            transform.position = mousePos;
        }
        else
        {
        }
    }
}
     

