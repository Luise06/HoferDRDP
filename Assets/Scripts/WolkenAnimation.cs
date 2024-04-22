using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolkenAnimation : MonoBehaviour
{
    Animation anim;
    GameObject animObject;
    // Start is called before the first frame update
    void Start()
    {
        animObject = GameObject.Find("Move");
        animObject.GetComponent<Animator>().Play("WolkenBewegen");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
