using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detector : MonoBehaviour
{
    public SpriteRenderer detectorRenderer;
    public float colourChangeDistance;
    // Start is called before the first frame update
    void Start()
    {
        detectorRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 first = transform.position;
            Vector3 second = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        second.z = 0f;
      float distancebetween = Vector3.Distance(first, second); 
        
        if (distancebetween < colourChangeDistance)
        {
            detectorRenderer.color = Color.red;
        }
        else
        {
            detectorRenderer.color = Color.white;
        }
    }
}
