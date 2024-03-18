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

    /* public List<GameObject> gutscheine;
     public List<int> gewonnenGutschein;
     public GameObject gutscheinanzeige;
     private bool hasWon = false;*/



    //public static LoadSceneScript instance;


    void Start()
    {
        particelSystem.SetActive(false);
        // gutscheinanzeige.SetActive(false);
        // Deaktivieren Sie alle Gutscheine, bevor Sie den gewonnenen Gutschein aktivieren
        // Deaktivieren Sie alle Gutscheine, bevor Sie den gewonnenen Gutschein aktivieren


        // Wechseln Sie zur nächsten Szene
        //SceneManager.LoadScene("Scene2");
        // Wählen Sie zufällig einen Gutschein aus der Liste aus
        int randomIndex = Random.Range(0, gutscheinListe.Count);
        GameObject gewonnenerGutschein = gutscheinListe[randomIndex];

        // Durchlaufen Sie alle Gutscheine und deaktivieren Sie sie, außer dem gewonnenen Gutschein
        foreach (GameObject gutschein in gutscheinListe)
        {
            gutschein.SetActive(gutschein == gewonnenerGutschein);
        }

        // Speichern Sie den Namen des gewonnenen Gutscheins in PlayerPrefs
        PlayerPrefs.SetString("GewonnenerGutschein", gewonnenerGutschein.name);
        PlayerPrefs.Save();

        // Wechseln Sie zur nächsten Szene
        //SceneManager.LoadScene("Scene2");
    }








    void Update()
    {
        if (StaticVariablen.gewonnen == "Glückwunsch!!!")
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
                gutscheine.Remove(randomGutschein);
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


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }


    public void GutscheinGewonnen(GameObject gutschein)
    {
      

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
