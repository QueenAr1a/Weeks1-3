using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changerright : MonoBehaviour
{
    private float timeAlive = 0f;
    public SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        timeAlive += Time.deltaTime;

        if(timeAlive > 3)
        {
            spriteRenderer.color = Color.green;
        }
    }
}
