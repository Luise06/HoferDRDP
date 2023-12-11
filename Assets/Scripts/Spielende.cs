using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spielende : MonoBehaviour
{

    public void Lost()
    {
        SceneManager.LoadScene("GewonnenVerloren");
        //StaticVariablen.gewonnen = "Schade ):";
    }
    public void NeuerHighscore()
    {
        SceneManager.LoadScene("GewonnenVerloren");
        

    }

    public void Home()
    {
        SceneManager.LoadScene("Hauptmenue");
    }
}
