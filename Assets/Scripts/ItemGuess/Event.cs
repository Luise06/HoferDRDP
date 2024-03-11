using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Event : MonoBehaviour
{
    public Sprite[] productSprites; // Sprites der Tierbilder
    public Sprite[] shadowSprites; // Sprites der Schattenbilder

    public Image shadowImage; // Das Bild des Schattens
    public Button[] answerButtons; // Buttons f�r die Antworten

    private int correctAnswerIndex; // Index des korrekten Tieres
    private int[] answerIndices; // Indizes der Antworten (inkl. der korrekten Antwort)

    void Start()
    {
        GenerateQuestion();
        SetAnswers();
    }

    void GenerateQuestion()
    {
        // Zuf�lliges Tier ausw�hlen
        correctAnswerIndex = Random.Range(0, productSprites.Length);

        // Schattenbild setzen
        shadowImage.sprite = shadowSprites[correctAnswerIndex];
    }

    void SetAnswers()
    {
        // Zuf�llige Indizes f�r die Antwortbuttons generieren
        answerIndices = new int[answerButtons.Length];
        for (int i = 0; i < answerButtons.Length; i++)
        {
            int randomIndex = Random.Range(0, productSprites.Length);
            answerIndices[i] = randomIndex;
            answerButtons[i].GetComponent<Image>().sprite = productSprites[randomIndex];

            // Button-Handler mit der CheckAnswer-Funktion verkn�pfen
            int buttonIndex = i;
            answerButtons[i].onClick.AddListener(() => CheckAnswer(buttonIndex));
        }

        // Zuf�llige Antwort-Buttons neu setzen, um die richtige Antwort einzuf�gen
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
