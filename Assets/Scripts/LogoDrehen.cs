using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogoDrehen : MonoBehaviour
{
    [SerializeField] Animator LogoAnimator;
    
    public bool infosAnzeigen;
    public void LogoUmdrehen()
    {
        //Debug.Log(gameObject.name);
        if (infosAnzeigen)
        {
            LogoAnimator.SetBool("InfosAnzeigen", true);
            infosAnzeigen = false;
        }
        else
        {
            LogoAnimator.SetBool("InfosAnzeigen", false);
            infosAnzeigen = true;
        }
        
            
        
        //logo.SetActive(false);
    }
}
