using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class gutscheineanzeigen : MonoBehaviour
{
    public List<GameObject> gutscheinListe = new List<GameObject>();

    void Start()
    {
        // Laden des Namens des gewonnenen Gutscheins aus PlayerPrefs
        string gewonnenerGutscheinName = PlayerPrefs.GetString("GewonnenerGutschein");

        // Durchlaufen Sie alle Gutscheine und aktivieren Sie nur den gewonnenen Gutschein
        foreach (GameObject gutschein in gutscheinListe)
        {
            gutschein.SetActive(gutschein.name == gewonnenerGutscheinName);
        }
    }
}





