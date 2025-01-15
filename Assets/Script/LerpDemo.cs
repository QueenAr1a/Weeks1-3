using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpDemo : MonoBehaviour
{
    [Range(0f, 1f)]
    public float t;

    public Transform start;
    public Transform end;
    public Vector2 nothelpful;

    public AnimationCurve curve;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.localScale = Vector2.one * AnimationCurve.Evaluate(t);
        //Vector2 pos = new Vector2(Mathf.Lerp(-4, 5, t), 0);
        transform.position = Vector2.Lerp(start.position, end.position, curve.Evaluate(t));
    }
}
