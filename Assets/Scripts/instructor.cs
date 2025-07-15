using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class instructor : MonoBehaviour
{
    public float start;
    public float end;
    public float current = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       // float start;
       // float end;
          //  float current; tho these 3 should be in start
        // needed when ever using lerp since it needs the 3 xyz values this is lerp starting syntax
        float output = Mathf.Lerp(start, end, current);
        // if current time is 0 Lerp will give us the stat value which is 100 in this case,
        // if current time is 0.5 then lerp gives us 50 which is half way between start and end
        // if current time is 1 then the lerp gives us 1 
        Debug.Log(output.ToString());
    }
}
