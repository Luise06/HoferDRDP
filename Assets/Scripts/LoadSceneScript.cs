using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneScript : MonoBehaviour
{
    public TextMeshProUGUI gewonnenVerlorenText;
    public GameObject gewonnenPanel;
    public GameObject verlorenPanel;

    public TextMeshProUGUI highScore;
    public TextMeshProUGUI score;
    //public TextMeshProUGUI text;
    public GameObject particelSystem;
    public AudioSource loseAudio;
    bool einemalAbgespielt = true;


    public List<GameObject> gutscheinListe = new List<GameObject>();

     public List<GameObject> gutscheine;
     public List<int> gewonnenGutschein;
     public GameObject gutscheinanzeige;
     private bool hasWon = false;



    //public static LoadSceneScript instance;


    void Start()
    {
        particelSystem.SetActive(false);

        int randomIndex = Random.Range(0, gutscheinListe.Count);
        GameObject gewonnenerGutschein = gutscheinListe[randomIndex];

        foreach (GameObject gutschein in gutscheinListe)
        {
            gutschein.SetActive(gutschein == gewonnenerGutschein);
        }

        string gutscheinName = "GutscheinNR" + randomIndex;
        PlayerPrefs.SetInt(gutscheinName, 1);
        Debug.Log(gutscheinName + " wurde in den PlayerPrefs angelegt!");
        //PlayerPrefs.SetString("GewonnenerGutschein", gewonnenerGutschein.name);
        PlayerPrefs.Save();

    }








    void Update()
    {
        if (StaticVariablen.gewonnen == "Gl�ckwunsch!!!")
        {
            gewonnenPanel.SetActive(true);
            verlorenPanel.SetActive(false);
            particelSystem.SetActive(true);
            highScore.text = PlayerPrefs.GetInt("HighScore").ToString();
            // CheckWinCondition();




        }
        else
        {
            // gutscheinanzeige.SetActive(false);

            verlorenPanel.SetActive(true);
            gewonnenPanel.SetActive(false);
            score.text = StaticVariablen.score.ToString();
            if (einemalAbgespielt)
            {
                loseAudio.Play(0);
                einemalAbgespielt = false;
            }

        }
    }

  /*public void ShowGutschein()
    {
        if (!gutscheinanzeige.activeSelf)
        {
            gutscheinanzeige.SetActive(true);

            if (!PlayerPrefs.HasKey("Gutschein"))
            {
                GameObject randomGutschein = gutscheine[Random.Range(0, gutscheine.Count)];

                GameObject instantiatedGutschein = Instantiate(randomGutschein, gutscheinanzeige.transform);
                
                PlayerPrefs.SetString("Gutschein", randomGutschein.name);
                
                Debug.Log("ausgesucht");
            }
            else
            {
                
                string existingGutscheinName = PlayerPrefs.GetString("Gutschein");
                GameObject existingGutschein = gutscheine.Find(g => g.name == existingGutscheinName);
                if (existingGutschein != null)
                {
                    Instantiate(existingGutschein, gutscheinanzeige.transform);
                }
            }

            
        }
    }

    
   

    public void SpeichereGutschein()
    {
        if (!PlayerPrefs.HasKey("Gutschein"))
        {
            
            GameObject randomGutschein = GetRandomGutschein();

            PlayerPrefs.SetString("Gutschein", randomGutschein.name);

        }

        Debug.Log("wird gespeichert");

    }

    public GameObject GetRandomGutschein()
    {
        if (gutscheine.Count == 0)
        {
           
            return null;
        }

        int randomIndex = Random.Range(0, gutscheine.Count);
        gewonnenGutschein.Add(randomIndex);
        return gutscheine[randomIndex];



    }


    


   

    public void CheckWinCondition()
    {
        hasWon = true;

        if (hasWon)
        {
            SpeichereGutschein();
        }
    }*/

    public void SceneLaden()
    {
        SceneManager.LoadScene("foodDrop");
    }
}
