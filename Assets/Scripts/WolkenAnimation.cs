using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolkenAnimation : MonoBehaviour
{
    public Animation anim;
    // Start is called before the first frame update
    void Start()
    {
        anim.Play("WolkenBewegen");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
