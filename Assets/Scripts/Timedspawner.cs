using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timedspawner : MonoBehaviour
{
    public GameObject prefabspawn;
    public float spawnfrequency;
    private float timesince = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timesince += Time.deltaTime; 
        //making time since be tracked by time
        if(timesince > spawnfrequency)
        {
            Instantiate(prefabspawn);
        }
    }
}
