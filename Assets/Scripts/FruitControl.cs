using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitControl : MonoBehaviour
{
     string inTheCloud = "y";
    void Start()
    {
        if (transform.position.y < 2.91)
        {
            inTheCloud = "n";
        }
    }


    void Update()
    {
        if (inTheCloud == "y")
        {
            GetComponent<Transform>().position = CloudControl.cloudxPos;
        }

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Ended)
            {
                GetComponent<Rigidbody2D>().gravityScale = 1;
                inTheCloud = "n";
                CloudControl.spawnedYet = "n";
            }
        }

        if (Input.GetKeyDown("space"))
        {
            GetComponent<Rigidbody2D>().gravityScale = 1;
            inTheCloud = "n";
            CloudControl.spawnedYet = "n"; 
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == gameObject.tag)
        {
            CloudControl.spawnPos = transform.position;
            CloudControl.newfruit = "y";
            CloudControl.whichFruit = int.Parse(gameObject.tag);
            Destroy(gameObject);
        }
    }
}
