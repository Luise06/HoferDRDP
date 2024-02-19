using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    public float totalTime = 30f; // Gesamtzeit des Countdowns
    private float currentTime; // Aktuelle verbleibende Zeit
    public TextMeshProUGUI countdownText; // Referenz auf das Textobjekt, das den Countdown anzeigt

    //private bool isCounting = false; // Überprüft, ob der Countdown gerade läuft

    void Start()
    {
        currentTime = totalTime;
        UpdateCountdownText();
        
    }

    void Update()
    {
        
            currentTime -= Time.deltaTime;
            UpdateCountdownText();
            if (currentTime <= 0)
            {
                currentTime = 0;
                isCounting = false;
                // Hier kannst du die Methode aufrufen, die ausgeführt werden soll, wenn der Countdown abgelaufen ist.
                CountdownFinished();
            }
        
    }

    void UpdateCountdownText()
    {
        int seconds = Mathf.FloorToInt(currentTime % 60);
        countdownText.text = seconds.ToString();
    }

    

    void CountdownFinished()
    {
        Debug.Log("Countdown abgeschlossen!");
        // Hier kannst du weitere Aktionen ausführen, wenn der Countdown abgeschlossen ist.
    }
}