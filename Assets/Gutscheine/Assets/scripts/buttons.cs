using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttons : MonoBehaviour
{

    public List<Button> gutscheinListe = new List<Button>();
    

    public GameObject hideContent;
    public GameObject rotscan, gelbscan, blauscan, orangescan;
    public Button rot01, rot02, gelb01, gelb02, blau01, blau02, orange01, orange02;
    public GameObject returnbutton;

    public gutscheineanzeigen anzeigen;


    // Start is called before the first frame update
    void Start()
    {

        for (int i = 0; i < gutscheinListe.Count; i++)
        {
            string gutscheinName = "GutscheinNR" + i;
            int isSaved = PlayerPrefs.GetInt(gutscheinName);

            if (isSaved == 1)
            {
                //gutscheinListe[i].SetActive(true);
                Debug.Log("Gutschein wird angezeigt");
                gutscheinListe[i].interactable = true;
            }
            else
            {
                gutscheinListe[i].interactable = false;

            }




        }

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
            //rot01.interactable = false;
            // rot02.interactable = false;
            

        }

        if (blauscan)
        {
            string gutscheinName = "GutscheinNR" + 4;
            string gutscheinName02 = "GutscheinNR" + 5;
            int isSaved = PlayerPrefs.GetInt(gutscheinName);



            blauscan.SetActive(false);
            hideContent.SetActive(true);
            blau01.interactable = false;

            PlayerPrefs.SetInt(gutscheinName, 0);
            PlayerPrefs.SetInt(gutscheinName02, 0);
            PlayerPrefs.Save();

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
