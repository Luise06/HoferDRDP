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

    public List<GameObject> gutscheine;
    public GameObject gutscheinanzeige;
    private bool hasWon = false;


    void Start()
    {
        particelSystem.SetActive(false);
        gutscheinanzeige.SetActive(false);
    }

    void Update()
    {
        if (StaticVariablen.gewonnen == "Glückwunsch!!!")
        {
            gewonnenPanel.SetActive(true);
            verlorenPanel.SetActive(false);
            particelSystem.SetActive(true);
            highScore.text = PlayerPrefs.GetInt("HighScore").ToString();


            hasWon = true;

            if (hasWon)
            {
                ShowGutschein();
            }


        }
        else
        {
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

    public void ShowGutschein()
    {
        // Überprüfe, ob das Gutscheinfeld bereits angezeigt wird
        if (!gutscheinanzeige.activeSelf)
        {
            // Aktiviere das Gutscheinfeld
            gutscheinanzeige.SetActive(true);

            // Überprüfe, ob der Spieler bereits einen Gutschein hat
            if (!PlayerPrefs.HasKey("Gutschein"))
            {
                // Wähle einen zufälligen Gutschein aus der Liste aus
                GameObject randomGutschein = gutscheine[Random.Range(0, gutscheine.Count)];

                // Instanziere den ausgewählten Gutschein und platziere ihn im Gutscheinfeld
                GameObject instantiatedGutschein = Instantiate(randomGutschein, gutscheinanzeige.transform);

                // Speichere den Gutschein in den PlayerPrefs, damit er beim nächsten Mal nicht erneut angezeigt wird
                PlayerPrefs.SetString("Gutschein", randomGutschein.name);
            }
            else
            {
                // Wenn der Spieler bereits einen Gutschein hat, zeige ihn an
                string existingGutscheinName = PlayerPrefs.GetString("Gutschein");
                GameObject existingGutschein = gutscheine.Find(g => g.name == existingGutscheinName);
                if (existingGutschein != null)
                {
                    Instantiate(existingGutschein, gutscheinanzeige.transform);
                }
            }
        }
    }

    public void CheckWinCondition()
    {
       
    }

        public void SceneLaden()
    {
        SceneManager.LoadScene("foodDrop");
    }
}
