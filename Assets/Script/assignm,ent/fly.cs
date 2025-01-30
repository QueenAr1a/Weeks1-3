using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fly : MonoBehaviour
{
    //this will be used to make the fly lerp to the fruit when the mouse is held down
    //the range here is just for the slider on inspect
    [Range(0, 1)]
    // this will represent the time
    public float t;
    // this just lets us have a curve for the fly to follow
    public AnimationCurve curve;
    // and start and end give us the points ot will go to, in this case starting at the fruit jar and ending at the mouse(fruit)
    public Transform start;
    public Transform end;
    public Vector2 nothelpful;
    // Start is called before the first frame update
    void Start()
    {
        t = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //AGAIN setting up the the mouse position like i did in fruit amnd making it only play when the mouse is held
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (Input.GetMouseButton(0))
        {
            //all these tell the fly where to lerp to, and how to evaluate. lerp tells it to move from a-b by t and transform sets those values and does it
            Vector2 scale = transform.localScale;
            float x = Mathf.Lerp(0, 1, t);
            transform.position = Vector2.Lerp(start.position, end.position, curve.Evaluate(t));

        }
        else
        {
        }
    }
}
