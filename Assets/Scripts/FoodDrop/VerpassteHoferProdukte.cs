using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class VerpassteHoferProdukte : MonoBehaviour
{
    public int verpassteProdukte;
    public VerschiedeneScene verschiedeneSceneScript;
    public TextMeshProUGUI missedText;
    public AudioSource audioMiss;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "HoferProdukt")
        {
            verpassteProdukte++;
            missedText.text = verpassteProdukte.ToString();
            Destroy(collision);
            audioMiss.Play(0);
            /*if (einmalAbspielen)
            {
                
                einmalAbspielen = false;
            }*/
            
        }

    }
    private void Update()
    {
        if (verpassteProdukte >= 3)
        {
            verschiedeneSceneScript.Lost();
        }

    }
}
