using UnityEngine;
using UnityEngine.SceneManagement; 
using UnityEngine.UI; 

public class GameManagment : MonoBehaviour
{
    public static GameManagment Instance; 

    public GameObject gameOverUI; 
    public GameObject gameWonUI;  

    private void Awake()
    {
     
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void GameOver()
    {
        StaticVariablen.gewonnen = "Schade";
        StaticVariablen.hatHighscore = false;
        StaticVariablen.whichScene = "DrinkMerger";

        Debug.Log("Spiel verloren!");
        // Zeige den Game Over-Bildschirm an
        if (gameOverUI != null)
        {
            gameOverUI.SetActive(true);
        }
        // Optional: Szene neu laden
        // SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameWon()
    {
        StaticVariablen.gewonnen = "Glückwunsch!!!";
        StaticVariablen.hatHighscore = false;
        StaticVariablen.whichScene = "DrinkMerger";

        Debug.Log("Spiel gewonnen!");
        // Zeige den Game Won-Bildschirm an
        if (gameWonUI != null)
        {
            gameWonUI.SetActive(true);
        }
        // Optional: Szene neu laden
        // SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}


