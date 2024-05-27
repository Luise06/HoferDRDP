using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseSkript : MonoBehaviour
{
    public Button Button1;
    public Button Button2;
    public Button Button3;
    public Button Button4;
    public GameObject WeiterButton;
    public GameObject HomeButton;
    public GameObject Spieleliste;
    public GameObject PauseScreen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void Pause()
    {
        Button1.enabled = false;
        Button2.enabled = false;
        Button3.enabled = false;
        Button4.enabled = false;
        WeiterButton.SetActive(true);
        HomeButton.SetActive(true);
        Spieleliste.SetActive(true);
        PauseScreen.SetActive(true);
    }

    public void HomeButtonButton()
    {
        SceneManager.LoadScene("Hauptmenue");
    }

    public void SpielelisteButton()
    {
        SceneManager.LoadScene("Spielauswahl");
    }

    public void WeiterButtonButton()
    {
        WeiterButton.SetActive(false);
        HomeButton.SetActive(false);
        Spieleliste.SetActive(false);
        PauseScreen.SetActive(false);
        Button1.enabled = true;
        Button2.enabled = true;
        Button3.enabled = true;
        Button4.enabled = true;
    }

}
