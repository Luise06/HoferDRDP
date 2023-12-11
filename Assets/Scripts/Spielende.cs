using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spielende : MonoBehaviour
{

    public void Lost()
    {
        SceneManager.LoadScene(1);
        //StaticVariablen.gewonnen = "Schade ):";
    }
    public void NeuerHighscore()
    {
        SceneManager.LoadScene(1);
        

    }

    public void Home()
    {
        SceneManager.LoadScene(0);
    }
}
