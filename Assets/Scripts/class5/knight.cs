using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class knight : MonoBehaviour
{
    public GameObject fireballprefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            {
            GameObject spawnedobject;
            //instantiate returns the copiedgmae object that is made with the prefab then get compent give us acces to the transform of the spawed object
         spawnedobject = Instantiate(fireballprefab, transform.position, transform.rotation);
            //We use GetComponent to get access to the Transform component off of the spawned object
            Transform spawnedtransform = spawnedobject.GetComponent<Transform>();
            //We can set the parent of the spawnedTransform using SetParent
            spawnedtransform.transform.SetParent(transform);

            //We can remove the parent of the spawnedTransform by setting parent as equal to null
            spawnedtransform.parent = null;
        }
           
        
        

    }
}
