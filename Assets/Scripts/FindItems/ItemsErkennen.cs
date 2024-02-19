using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ItemsErkennen : MonoBehaviour
{
    ChooseRandomItem chooseRandomItem;
    public TextMeshProUGUI debugText;
    public void ObjektAussuchen()
    {
        Debug.Log("richtiges Objekt");
        if (gameObject.tag == chooseRandomItem.gesuchterTagName)
        {
            Debug.Log("richtiges Objekt");
        }
    }
    
    
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (Input.GetMouseButton(0))
        {
            Debug.Log("Maus Gedrückt");
        }
    }
}
