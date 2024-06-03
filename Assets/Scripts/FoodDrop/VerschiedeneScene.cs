using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VerschiedeneScene : MonoBehaviour
{
    public void Spielauswahl()
    {
        SceneManager.LoadScene("Spielauswahl");
    }
    public void FoodDrop()
    {
        SceneManager.LoadScene("foodDrop");
    }
    public void ZweiteKassaBitte()
    {
        SceneManager.LoadScene("KassaSchrei");
    }
    
    public void Watermelon()
    {
        SceneManager.LoadScene(10);
    }
    public void Lost()
    {
        SceneManager.LoadScene("GewonnenVerloren");
        //StaticVariablen.gewonnen = "Schade ):";
    }
    public void NeuerHighscore()
    {
        SceneManager.LoadScene("GewonnenVerloren");
    }
    public void FindItemSpiel()
    {
        SceneManager.LoadScene("FindItem");
    }

    public void Home()
    {
        SceneManager.LoadScene("Hauptmenue");
    }

    public void Gutscheine()
    {
        SceneManager.LoadScene("Gutscheine");
    }

    public void ItemGuesser()
    {
        SceneManager.LoadScene("ItemGuess");
    }
}
