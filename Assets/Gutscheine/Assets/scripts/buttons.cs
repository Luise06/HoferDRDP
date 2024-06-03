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

    //public gutscheineanzeigen anzeigen;


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
             string gutscheinName00 = "GutscheinNR" + 0;
             string gutscheinName01 = "GutscheinNR" + 1;
             int isSaved = PlayerPrefs.GetInt(gutscheinName00);
             int isSaved01 = PlayerPrefs.GetInt(gutscheinName01);

            rotscan.SetActive(false);
             hideContent.SetActive(true);
             rot01.interactable = false;
             rot02.interactable = false;


             PlayerPrefs.SetInt(gutscheinName00, 0);
             PlayerPrefs.SetInt(gutscheinName01, 0);
             

            PlayerPrefs.Save();
            
        }

        if (blauscan)
        {
            string gutscheinName04 = "GutscheinNR" + 4;
            string gutscheinName05 = "GutscheinNR" + 5;
            int isSaved04 = PlayerPrefs.GetInt(gutscheinName04);
            int isSaved05 = PlayerPrefs.GetInt(gutscheinName05);



            blauscan.SetActive(false);
            hideContent.SetActive(true);
            blau01.interactable = false;
            blau02.interactable = false;

            PlayerPrefs.SetInt(gutscheinName04, 0);
            PlayerPrefs.SetInt(gutscheinName05, 0);
            PlayerPrefs.Save();

        }

        if (gelbscan)
        {
            string gutscheinName02 = "GutscheinNR" + 2;
            string gutscheinName03 = "GutscheinNR" + 3;
            int isSaved02 = PlayerPrefs.GetInt(gutscheinName02);
            int isSaved03 = PlayerPrefs.GetInt(gutscheinName03);

            gelbscan.SetActive(false);
            hideContent.SetActive(true);
            gelb01.interactable = false;
            gelb02.interactable = false;

            PlayerPrefs.SetInt(gutscheinName02, 0);
            PlayerPrefs.SetInt(gutscheinName03, 0);
            PlayerPrefs.Save();
        }

        if (orangescan)
        {
            string gutscheinName06 = "GutscheinNR" + 6;
            string gutscheinName07 = "GutscheinNR" + 7;
            int isSaved06 = PlayerPrefs.GetInt(gutscheinName06);
            int isSaved07 = PlayerPrefs.GetInt(gutscheinName07);

            orangescan.SetActive(false);
            hideContent.SetActive(true);
            orange01.interactable = false;
            orange02.interactable = false;

            PlayerPrefs.SetInt(gutscheinName06, 0);
            PlayerPrefs.SetInt(gutscheinName07, 0);
            PlayerPrefs.Save();
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
