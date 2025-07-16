using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeMover : MonoBehaviour
{
    public Sprite wood;
 
    public SpriteRenderer Tree;
    public float speed;
  
    // Start is called before the first frame update
    void Start()
    {
        Tree = gameObject.GetComponent<SpriteRenderer>();
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.right * speed;
        Vector3 TreeposinScreen = Camera.main.WorldToScreenPoint(transform.position);

        if(TreeposinScreen.x > Screen.width / 3)
        {
            speed = 0.003f;
        }


        if (TreeposinScreen.x > Screen.width/2)
        {
            Tree.sprite = wood;
        }
        if (TreeposinScreen.x > Screen.width / 2)
        {
            transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        }

        if (TreeposinScreen.x > Screen.width / 1.5f)
        {
            speed = 0.01f;
        }
    }
}
