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
        //score.text = StaticVariablen.score.ToString();
        particelSystem.SetActive(false);
        Debug.Log(PlayerPrefs.GetInt("HighScore"));
    }

    void Update()
    {
        if (StaticVariablen.gewonnen == "Glückwunsch!!!")
        {
            gewonnenPanel.SetActive(true);
            verlorenPanel.SetActive(false);
            //gewonnenVerlorenText.text = StaticVariablen.gewonnen;
            particelSystem.SetActive(true);
            //text.text = "Dein neuer Highscore ist ";
            highScore.text = PlayerPrefs.GetInt("HighScore").ToString();
        }
        else
        {
            verlorenPanel.SetActive(true);
            gewonnenPanel.SetActive(false);
            score.text = StaticVariablen.score.ToString();
            //int punkteGebraucht = PlayerPrefs.GetInt("HighScore") - StaticVariablen.score +1;
            //text.text = "Du hättest noch "  + punkteGebraucht + " Punkte gebraucht um den Highscore zu schlagen.";
            //highScore.text = 
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
