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
    private void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.touches[0].position);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.tag == "Disco")
                {
                    GameObject temp = hit.transform.gameObject;

                }
            }
        }
    }
}
