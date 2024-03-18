using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Event : MonoBehaviour
{
    public Sprite[] productSprites; // Sprites der Tierbilder
    public Sprite[] shadowSprites; // Sprites der Schattenbilder

    public Image shadowImage; // Das Bild des Schattens
    public Button[] answerButtons; // Buttons für die Antworten

    private int correctAnswerIndex; // Index des korrekten Tieres
    private int[] answerIndices; // Indizes der Antworten (inkl. der korrekten Antwort)

    void Start()
    {
        GenerateQuestion();
        SetAnswers();
    }

    void GenerateQuestion()
    {
        // Zufälliges Tier auswählen
        correctAnswerIndex = Random.Range(0, productSprites.Length);

        // Schattenbild setzen
        shadowImage.sprite = shadowSprites[correctAnswerIndex];
    }

    void SetAnswers()
    {
        // Zufällige Indizes für die Antwortbuttons generieren
        answerIndices = new int[answerButtons.Length];
        for (int i = 0; i < answerButtons.Length; i++)
        {
            int randomIndex = Random.Range(0, productSprites.Length);
            answerIndices[i] = randomIndex;
            answerButtons[i].GetComponent<Image>().sprite = productSprites[randomIndex];

            // Button-Handler mit der CheckAnswer-Funktion verknüpfen
            int buttonIndex = i;
            answerButtons[i].onClick.AddListener(() => CheckAnswer(buttonIndex));
        }

        // Zufällige Antwort-Buttons neu setzen, um die richtige Antwort einzufügen
        int correctAnswerButtonIndex = Random.Range(0, answerButtons.Length);
        answerButtons[correctAnswerButtonIndex].GetComponent<Image>().sprite = productSprites[correctAnswerIndex];
    }

    void CheckAnswer(int buttonIndex)
    {
        if (answerIndices[buttonIndex] == correctAnswerIndex)
        {
            Debug.Log("Richtig! Das war das richtige Tier.");
        }
        else
        {
            Debug.Log("Falsch! Das war nicht das richtige Tier.");
        }

        // Neue Frage generieren
        GenerateQuestion();
        SetAnswers();
    }
}
