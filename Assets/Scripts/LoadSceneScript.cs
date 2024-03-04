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

    public List<GameObject> gutscheinegewonnen;
    public GameObject gewonnenanzeige;

    public static LoadSceneScript instance;


    void Start()
    {
        particelSystem.SetActive(false);
        gutscheinanzeige.SetActive(false);
        gewonnenanzeige.SetActive(false);
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
                gutscheinegewonnen.Add(randomGutschein);
                
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

    
   

    private void SpeichereGutschein()
    {
        if (!PlayerPrefs.HasKey("Gutschein"))
        {
            
            GameObject randomGutschein = GetRandomGutschein();

            PlayerPrefs.SetString("Gutschein", randomGutschein.name);
        }

      

    }

    private GameObject GetRandomGutschein()
    {
        if (gutscheine.Count == 0)
        {
            Debug.LogWarning("Die Liste der Gutscheine ist leer.");
            return null;
        }

        int randomIndex = Random.Range(0, gutscheine.Count);
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
      //  LoadSceneScript.instance.gewonneneGutscheine.Add(gutschein);
    }

    public void CheckWinCondition()
    {
        hasWon = true;

        if (hasWon)
        {
            SpeichereGutschein();
        }
    }

        public void SceneLaden()
    {
        SceneManager.LoadScene("foodDrop");
    }
}
