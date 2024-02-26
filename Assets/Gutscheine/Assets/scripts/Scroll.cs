using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scroll : MonoBehaviour
{
    /* public GameObject scrollbar;
     float Scroll_pos = 0;
     float[] pos;





     private void Update()
     {
         pos = new float[transform.childCount];
         float distance = 1f / (pos.Length - 1f);
         for (int i = 0; i < pos.Length; i++)
         {
             pos[i] = distance * i;
         }
         if (Input.GetMouseButton(0))
         {
             Scroll_pos = scrollbar.GetComponent<Scrollbar>().value;
         }
         else
         {
             for (int i = 0; i < pos.Length; i++)
             {
                 if (Scroll_pos< pos[i]+(distance/2) && Scroll_pos > pos[i]- (distance/2))
                 {
                     scrollbar.GetComponent<Scrollbar>().value = Mathf.Lerp(scrollbar.GetComponent<Scrollbar>().value, pos[i], 0.1f);
                 } 
             }
         }
         for (int i = 0; i < pos.Length; i++)
         {
             if (Scroll_pos < pos[i] + (distance / 2) && Scroll_pos > pos[i] - (distance / 2))
             {
                 transform.GetChild(i).localScale = Vector2.Lerp (transform.GetChild(i).localScale, new Vector2(1f, 1f),0.1f);
                 for (int a = 0; a < pos.Length; a++)
                     {
                     if (a != i)
                     {
                         transform.GetChild(a).localScale = Vector2.Lerp(transform.GetChild(a).localScale, new Vector2(0.8f,0.8f),01f);
                     }
                     }
                 {

                 }
             }
         }
     }*/
    public Scrollbar scrollbar;

    void Update()
    {
        // Überprüfen, ob der Benutzer mit dem Finger über das Display wischt
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            // Ändern Sie die Scrollposition basierend auf der Wischbewegung
            scrollbar.value += Input.GetTouch(0).deltaPosition.y / Screen.height;
        }
    }
    
}

