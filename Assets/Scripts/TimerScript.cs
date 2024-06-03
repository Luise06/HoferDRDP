using UnityEngine;
using UnityEngine.UI; // Falls du UI-Elemente verwenden möchtest

public class TimerScript : MonoBehaviour
{
    public float timeRemaining = 60; // Zeit in Sekunden
    public bool timerIsRunning = false;
    public Text timeText; // UI-Text zur Anzeige der Zeit (optional)
    [SerializeField] GameObject gameManager;

    void Start()
    {
        // Timer starten
        timerIsRunning = true;
    }

    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
            }
            else
            {
                Debug.Log("Zeit abgelaufen!");
                timeRemaining = 0;
                timerIsRunning = false;
                GameManagment.Instance.GameOver(); // Rufe die GameOver-Methode des GameManagers auf
            }
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        if (timeText != null)
        {
            timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }
    }
}


