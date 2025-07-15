using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pacer : MonoBehaviour
{
<<<<<<< Updated upstream
=======
<<<<<<< HEAD

    public float speed;
  

    private float direction = 1;
    // Start is called before the first frame update
    void Start()
    {
        
=======
>>>>>>> Stashed changes
    public float speed;
    //public Camera gameCamera;
    //can be used instead of main camera if multiple cameras but cant be used in a prefab
    /// </summary>

    private int direction = 1;

    // Start is called before the first frame update
    void Start()
    {

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
        transform.position += Vector3.right * speed * direction * Time.deltaTime;

        Vector3 pacerinscreen = Camera.main.WorldToScreenPoint(transform.position);
        //able to use camera.main instaed of making a game cam to get the main cam

        if(pacerinscreen.x > Screen.width)
        {
            direction *= -1f;
        }

        if(pacerinscreen.x <0)
=======
>>>>>>> Stashed changes
        transform.position += Vector3.right * speed * direction;

        Vector3 pacerPositionInScreenSpace = Camera.main.WorldToScreenPoint(transform.position);

        if (pacerPositionInScreenSpace.x > Screen.width)
        {
            direction *= -1;
        }
        if (pacerPositionInScreenSpace.x < 0)
<<<<<<< Updated upstream
=======
>>>>>>> f078f755225a407d480b3752efac5f05a95e41a6
>>>>>>> Stashed changes
        {
            direction *= -1;
        }

<<<<<<< Updated upstream

    }
}
=======
<<<<<<< HEAD
    }
}
=======

    }
}
>>>>>>> f078f755225a407d480b3752efac5f05a95e41a6
>>>>>>> Stashed changes
