using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ProdukteAuffangen : MonoBehaviour
{
    public int currentScore;
    [SerializeField] TextMeshProUGUI scoreText;
    public VerschiedeneScene verschiedeneSceneScript;
    public AudioSource audioSource;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "HoferProdukt")
        {
            currentScore++;
            StaticVariablen.score = currentScore;            //PlayerPrefs.SetInt("HighScore", currentScore);
            CheckHighScore();
            audioSource.Play(0);
            scoreText.text = currentScore.ToString();
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "KeinHoferProdukt")
        {
            verschiedeneSceneScript.Lost();
        }
    }
    void CheckHighScore()
    {
        if (currentScore > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", currentScore);
            StaticVariablen.gewonnen = "Glückwunsch!!!";
            //spielendeScript.NeuerHighscore();
        }
        else
        {
            StaticVariablen.gewonnen = "Schade ):";
        }
       
    }
}
