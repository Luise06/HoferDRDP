using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudControl : MonoBehaviour
{
    public Transform[] fruitObj;
    static public string spawnedYet = "n";
    static public Vector2 cloudxPos;
    static public Vector2 spawnPos;
    static public string newfruit = "n";
    static public int whichFruit = 0;
    private bool isTouching = false;

    private Transform currentFruit;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        spawnFruit();
        replaceFruit();
        HandleInput();

        cloudxPos = transform.position;
    }

    void HandleInput()
    {
        // tastatur 
        if (Input.GetKey("a"))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-2, 0);
        }
        else if (Input.GetKey("d"))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(2, 0);
        }
        else
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        }

        // touch screen
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Moved)
            {
                Vector3 touchPosition = Camera.main.ScreenToWorldPoint(new Vector3(touch.position.x, touch.position.y, Camera.main.nearClipPlane));
                transform.position = new Vector3(touchPosition.x, transform.position.y, transform.position.z);
                isTouching = true;
            }

          /*  if (touch.phase == TouchPhase.Ended)
            {
                Debug.Log(spawnedYet);
                DropFruit();
               /* if (isTouching)
                {
                    DropFruit();
                    isTouching = false;
                } 
            } */
        }
    }

    void spawnFruit()
    {
        if (spawnedYet == "n")
        {
            StartCoroutine(spawntimer());
            spawnedYet = "y";
        }
    }

    void replaceFruit()
    {
        if (newfruit == "y")
        {
            newfruit = "n";
            Instantiate(fruitObj[whichFruit + 1], spawnPos, fruitObj[0].rotation);
        }
    }

    IEnumerator spawntimer()
    {
        yield return new WaitForSeconds(.75f);
        currentFruit = Instantiate(fruitObj[Random.Range(0, 1)], transform.position, fruitObj[0].rotation);
        Debug.Log("new fruit!");
    }

    void DropFruit()
    {
        if (spawnedYet == "y")
        {
            newfruit = "y";
            Debug.Log(currentFruit.name);
            currentFruit.gameObject.GetComponent<Rigidbody2D>().gravityScale = 1;
            spawnedYet = "n";
            spawnPos = transform.position;
        }
    }
}


