using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KorbFollow : MonoBehaviour
{
    Vector3 pos;
    public float speed;
    public Transform korb;
    

    void Update()
    {
        pos.x = Input.mousePosition.x;
        korb.transform.position = new Vector3(pos.x,-4,0);
        korb.position.Set(pos.x, -4, 0);
        Debug.Log(pos);
    }
}
