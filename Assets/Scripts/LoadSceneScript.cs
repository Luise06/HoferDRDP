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
    public GameObject gewonnenNoHSPanel;
    public GameObject verlorenNoHSPanel;
    [SerializeField] GameObject kassaSchreiBG;
    [SerializeField] GameObject foodDropBG;

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
        

    }

    void Update()
    {
        if (StaticVariablen.gewonnen == "Glückwunsch!!!")
        {
            if(StaticVariablen.hatHighscore == false)
            {
                gewonnenNoHSPanel.SetActive(true);
                verlorenNoHSPanel.SetActive(false);
                particelSystem.SetActive(true);
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
            if (StaticVariablen.hatHighscore == true)
            {
                gewonnenPanel.SetActive(true);
                verlorenPanel.SetActive(false);
                particelSystem.SetActive(true);
                highScore.text = PlayerPrefs.GetInt("HighScore").ToString();
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
            gutscheinanzeige.SetActive(true);
        }
        else
        {
            // gutscheinanzeige.SetActive(false);
            if(StaticVariablen.hatHighscore == false)
            {
                verlorenNoHSPanel.SetActive(true);
                gewonnenNoHSPanel.SetActive(false);
            }
            if(StaticVariablen.hatHighscore == true)
            {
                verlorenPanel.SetActive(true);
                gewonnenPanel.SetActive(false);
                score.text = StaticVariablen.score.ToString();
            }
            if (einemalAbgespielt)
            {
                loseAudio.Play(0);
                einemalAbgespielt = false;
            }
        }
        if (StaticVariablen.whichScene == "KassaSchrei")
        {
            foodDropBG.SetActive(false);
            kassaSchreiBG.SetActive(true);
        }
        if (StaticVariablen.whichScene == "FoodDrop")
        {
            foodDropBG.SetActive(true);
            kassaSchreiBG.SetActive(false);
        }
        gutscheinanzeige.SetActive(false);
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
    public void KassaSchreiLaden()
    {
        SceneManager.LoadScene("KassaSchrei");
    }
}
