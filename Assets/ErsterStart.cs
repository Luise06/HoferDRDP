using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ErsterStart : MonoBehaviour
{
    public Button Button1;
    public Button Button2;
    public Button Button3;
    public Button Button4;
    public Button Pause;
    public GameObject Tutorial;
    public Button ZurueckSpieleauswahl;
    public Button SpielenTuto;
    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        if (Tutorial.activeSelf)
        {
            Button1.interactable = false;
            Button2.interactable = false;
            Button3.interactable = false;
            Button4.interactable = false;
            Pause.interactable = false;
            ZurueckSpieleauswahl.interactable = true;
            SpielenTuto.interactable = true;

        }

        if (!Tutorial.activeSelf)
        {
            Button1.interactable = true;
            Button2.interactable = true;
            Button3.interactable = true;
            Button4.interactable = true;
            Pause.interactable = true;
            ZurueckSpieleauswahl.interactable = false;
            SpielenTuto.interactable = false;
        }


    }

    public void ZurueckSpiele()
    {
        SceneManager.LoadScene("Spielauswahl");
    }

    public void Spielen()
    {
        Tutorial.SetActive(false);
    }


}
