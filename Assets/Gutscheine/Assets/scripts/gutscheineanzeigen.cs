using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class gutscheineanzeigen : MonoBehaviour
{
     public List<Button> gutscheinListe = new List<Button>();

    void Start()
    {
        // Laden des Namens des gewonnenen Gutscheins aus PlayerPrefs
        //string gewonnenerGutscheinName = PlayerPrefs.GetString("GewonnenerGutschein");

        // Durchlaufen Sie alle Gutscheine und aktivieren Sie nur den gewonnenen Gutschein
        //foreach (GameObject gutschein in gutscheinListe)
        //{
        //    gutschein.SetActive(gutschein.name == gewonnenerGutscheinName);
        //}

        //GetComponent<Button>().interactable = false;

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
    }

    public void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            ResetPlayerPrefs();
        }
    }

    public void ResetPlayerPrefs()
    {
        for (int i = 0; i < gutscheinListe.Count; i++)
        {
            string gutscheinName = "GutscheinNR" + i;
            PlayerPrefs.DeleteKey(gutscheinName);

        }
    }
}





