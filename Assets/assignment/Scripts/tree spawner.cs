using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treespawner : MonoBehaviour
{
    public GameObject prefabToSpawn;
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
            Destroy(spawnedcannonball, 10);
           
        }
    }
}
