using System.Collections;
using System.Collections.Generic;
using UnityEngine;
<<<<<<< Updated upstream
=======
<<<<<<< HEAD
using UnityEngine.Timeline;

public class Spawner : MonoBehaviour
{

    public GameObject prefabspawn;
    //lets you set the prefab
    public Vector3 spawnpoint;
    public List<GameObject> spawnedobjects = new List<GameObject>();
    public int framerate;
    //brackets say what will be stored in this case gaem objects and new list actaully makes the list
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = framerate;
       //GameObject spawnedobject = Instantiate(prefabspawn);
       // spawnedobjects.Add(spawnedobject);
        //adds the object to the list
        //gameobject spawned object creates a variables that stores the instantiated object for use (ex delete)
        //just spawns at 0,0
      // GameObject spawnedobject2 = Instantiate(prefabspawn, spawnpoint, Quaternion.identity);
        //spawns at the set location in inspector
       // spawnedobjects.Add(spawnedobject2);
        //Destroy(spawnedobject);
        //destroys object imedietly
        //Destroy(spawnedobject2, 3);
        //waits 3 seconds then destroys object
        //common problems, with instatiate, when you type it in you can follow specific converntions to us it to spawn it in a certain place, if not exact it has a fit
       // Destroy(spawnedobjects[0]);

=======
>>>>>>> Stashed changes

public class Spawner : MonoBehaviour
{
    public GameObject prefabToSpawn;
    public Vector3 spawnPoint;
    List<GameObject> spawnedObjects = new List<GameObject>();
    //List<int> numbers = new List<int>();

    // Start is called before the first frame update
    void Start()
    {
        //spawnedObjects { }

        //GameObject spawnedObject = Instantiate(prefabToSpawn);
        //spawnedObjects.Add(spawnedObject);

        ////spawnedObjects { spawnedObject[0] }

        //GameObject spawnedObject2 = Instantiate(prefabToSpawn, transform.position, Quaternion.identity);
        //spawnedObjects.Add(spawnedObject2);

        //Destroy(spawnedObjects[0]);

        //DONT DO THIS!!! The prefab is not to be touched >:(
        //Destroy(prefabToSpawn);
<<<<<<< Updated upstream
=======
>>>>>>> f078f755225a407d480b3752efac5f05a95e41a6
>>>>>>> Stashed changes
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< Updated upstream
=======
<<<<<<< HEAD
        if(Input.GetMouseButtonDown(0))
        {
            GameObject spawnedobject = Instantiate(prefabspawn);
            spawnedobjects.Add(spawnedobject);
=======
>>>>>>> Stashed changes
        if (Input.GetMouseButtonDown(0))
        {
            GameObject spawnedObject = Instantiate(prefabToSpawn);
            spawnedObjects.Add(spawnedObject);
<<<<<<< Updated upstream
=======
>>>>>>> f078f755225a407d480b3752efac5f05a95e41a6
>>>>>>> Stashed changes
        }

        if (Input.GetMouseButtonDown(1))
        {
<<<<<<< Updated upstream
=======
<<<<<<< HEAD
            for (int destroylist = 0; destroylist < spawnedobjects.Count; destroylist++)
            {
                Destroy(spawnedobjects[destroylist]);

            }
        }
            spawnedobjects.Clear();
            //basically says making a new int called I which starts at 0 and increases by 1 until it reachs the number of objects in the list. the list count you can also use a 
            //single lettervariable like i since its just for the loop. and use the spawnedobjects clear afterwar to kill the list
            //     for (int i = 0; i < spawnedobjects.Count; i++) 
            //{
             //   Destroy(spawnedobjects[i]);
           // }
    }
}
=======
>>>>>>> Stashed changes
            for (int i = 0; i < spawnedObjects.Count; i++)
            {
                Destroy(spawnedObjects[i]);
            }
            spawnedObjects.Clear();
        }
    }
<<<<<<< Updated upstream
}
=======
}
>>>>>>> f078f755225a407d480b3752efac5f05a95e41a6
>>>>>>> Stashed changes
