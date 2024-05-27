using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttons : MonoBehaviour
{

    public GameObject hideContent;
    public GameObject rotscan, gelbscan, blauscan, orangescan;
    public GameObject rot01, rot02, gelb01, gelb02, blau01, blau02, orange01, orange02;
    public GameObject returnbutton;


    // Start is called before the first frame update
    void Start()
    {
        
        rotscan.SetActive(false);
        blauscan.SetActive(false);
        orangescan.SetActive(false);
        gelbscan.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void ScanButton()
    {
        if (rotscan)
        {
            rotscan.SetActive(false);
           
            hideContent.SetActive(true);
        }

        if (blauscan)
        {
            blauscan.SetActive(false);
            hideContent.SetActive(true);
        }

        if (gelbscan)
        {
            gelbscan.SetActive(false);
            hideContent.SetActive(true);
        }

        if (orangescan)
        {
            orangescan.SetActive(false);
            hideContent.SetActive(true);
        }
    }

    public  void OnClickBlau() 
    {
        
     

  
            rotscan.SetActive(false);
            orangescan.SetActive(false);
            gelbscan.SetActive(false);
            blauscan.SetActive(true);
     
            hideContent.SetActive(false);
        
       
        
    }
    public void OnClickRot()
    {
        rotscan.SetActive(true);
        orangescan.SetActive(false);
        gelbscan.SetActive(false);
        blauscan.SetActive(false);
        Debug.Log("clicked");
        hideContent.SetActive(false);
    }

    public void OnClickOrange() 
    {
        orangescan.SetActive(true);
        gelbscan.SetActive(false);
        blauscan.SetActive(false);
        rotscan.SetActive(false);

        hideContent.SetActive(false);
    }

   public void OnCLickGelb() 
    {
        gelbscan.SetActive(true);
        rotscan.SetActive(false);
        blauscan.SetActive(false);
        orangescan.SetActive(false);
        //Debug.Log("clicked");
        hideContent.SetActive(false);
    }

}
