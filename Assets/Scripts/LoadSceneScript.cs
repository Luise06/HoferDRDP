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
    void Start()
    {
        particelSystem.SetActive(false);
    }

    void Update()
    {
        if (StaticVariablen.gewonnen == "Glückwunsch!!!")
        {
            gewonnenPanel.SetActive(true);
            verlorenPanel.SetActive(false);
            particelSystem.SetActive(true);
            highScore.text = PlayerPrefs.GetInt("HighScore").ToString();
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
    public void SceneLaden()
    {
        SceneManager.LoadScene("foodDrop");
    }
}
