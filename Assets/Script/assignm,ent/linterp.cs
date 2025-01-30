using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class linterp : MonoBehaviour
{
    [Range(0,1)]
    public float t;
    public AnimationCurve curve;
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
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (Input.GetMouseButton(0))
        {
           
            Vector2 scale = transform.localScale;
            float x = Mathf.Lerp(0, 1, t);
            transform.position = Vector2.Lerp(start.position, end.position, curve.Evaluate(t));

        }
        else
        {
        }
    }
}
