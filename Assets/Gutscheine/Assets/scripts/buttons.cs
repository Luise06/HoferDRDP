using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttons : MonoBehaviour
{
    public List<Button> gutscheinListe = new List<Button>();

    public GameObject hideContent;
    public GameObject rotscan, gelbscan, blauscan, orangescan;
    public GameObject rotscan02, gelbscan02, blauscan02, orangescan02;
    public Button rot01, rot02, gelb01, gelb02, blau01, blau02, orange01, orange02;
    public GameObject returnbutton;

    private Button activeButton;
    private GameObject activeScan;

    void Start()
    {
        for (int i = 0; i < gutscheinListe.Count; i++)
        {
            string gutscheinName = "GutscheinNR" + i;
            int isSaved = PlayerPrefs.GetInt(gutscheinName);

            if (isSaved == 1)
            {
                Debug.Log("Gutschein wird angezeigt");
                gutscheinListe[i].interactable = true;
            }
            else
            {
                gutscheinListe[i].interactable = false;
            }
        }

        rotscan.SetActive(false);
        rotscan02.SetActive(false);
        blauscan.SetActive(false);
        blauscan02.SetActive(false);
        orangescan.SetActive(false);
        orangescan02.SetActive(false);
        gelbscan.SetActive(false);
        gelbscan02.SetActive(false);
    }

    public void ScanButton()
    {
        if (activeScan != null && activeButton != null)
        {
            activeScan.SetActive(false);
            hideContent.SetActive(true);

            activeButton.interactable = false;
            int btnIndex = gutscheinListe.IndexOf(activeButton);
            if (btnIndex >= 0)
            {
                string gutscheinName = "GutscheinNR" + btnIndex;
                PlayerPrefs.SetInt(gutscheinName, 0);
            }

            PlayerPrefs.Save();

            activeButton = null;
            activeScan = null;
        }
    }

    public void OnClickBlau01()
    {
        ActivateScan(blauscan, blau01);
    }

    public void OnClickBlau02()
    {
        ActivateScan(blauscan02, blau02);
    }

    public void OnClickRot01()
    {
        ActivateScan(rotscan, rot01);
    }

    public void OnClickRot02()
    {
        ActivateScan(rotscan02, rot02);
    }

    public void OnClickOrange01()
    {
        ActivateScan(orangescan, orange01);
    }

    public void OnClickOrange02()
    {
        ActivateScan(orangescan02, orange02);
    }

    public void OnClickGelb01()
    {
        ActivateScan(gelbscan, gelb01);
    }

    public void OnClickGelb02()
    {
        ActivateScan(gelbscan02, gelb02);
    }

    private void ActivateScan(GameObject scanObject, Button button)
    {
        if (activeScan != null)
        {
            activeScan.SetActive(false);
        }

        activeScan = scanObject;
        activeButton = button;

        activeScan.SetActive(true);
        hideContent.SetActive(false);
    }
}
