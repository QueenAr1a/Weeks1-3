using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cannonballspawn : MonoBehaviour
{
    public GameObject prefabToSpawn;
    public Vector3 spawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject spawnedObject = Instantiate(prefabToSpawn);
           
        }
    }
}
