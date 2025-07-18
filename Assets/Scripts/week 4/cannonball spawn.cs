using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cannonballspawn : MonoBehaviour
{
    public GameObject prefabToSpawn;
    public float cannonballspeed;
    public float cannonballMoveDuration;
    public Color cannonballcolour;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        bool leftclick = Input.GetMouseButtonDown(0);
        if (leftclick)
        {
            GameObject spawnedcannonball = Instantiate(prefabToSpawn, transform.position, Quaternion.identity);
            SpriteRenderer cannonballRenderer = spawnedcannonball.GetComponent<SpriteRenderer>();
            // this gets access to the Sprite render and lets us use it
            cannonballRenderer.color = Color.red;
            //this changes it to red
            //set speed
            cannvball cannonballScript = spawnedcannonball.GetComponent<cannvball>();
               

                if (cannonballRenderer != null)
            {

            }

           //there are like 20 different instantiates
        }
        
    }
}
