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
            CheckWinCondition();

        }
        else
        {
            gutscheinanzeige.SetActive(false);

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
        if (!gutscheinanzeige.activeSelf)
        {
            gutscheinanzeige.SetActive(true);

            if (!PlayerPrefs.HasKey("Gutschein"))
            {
                GameObject randomGutschein = gutscheine[Random.Range(0, gutscheine.Count)];

                GameObject instantiatedGutschein = Instantiate(randomGutschein, gutscheinanzeige.transform);

                PlayerPrefs.SetString("Gutschein", randomGutschein.name);
                gutscheine.Remove(randomGutschein);
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

    public void CheckWinCondition()
    {
        hasWon = true;

        if (hasWon)
        {
            ShowGutschein();
        }
    }

        public void SceneLaden()
    {
        SceneManager.LoadScene("foodDrop");
    }
}
