using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Eventyy : MonoBehaviour
{
    public GameObject[] sprites;
    public GameObject[] shdwSprites;
    public string[] Antworten;
    public static string richtigeAntwort;
    public Button[] Buttons;
    public TextMeshProUGUI[] AntwortenText;

    // Start is called before the first frame update
    void Start()
    {
        int randomIndex = Random.Range(0, shdwSprites.Length);
        shdwSprites[randomIndex].SetActive(true);

        // Determine the correct answer based on randomIndex
        switch (randomIndex)
        {
            case 0:
                richtigeAntwort = "Disco";
                break;
            case 1:
                richtigeAntwort = "Cocos";
                break;
            case 2:
                richtigeAntwort = "Doppelkekse";
                break;
            case 3:
                richtigeAntwort = "Eistee";
                break;
            case 4:
                richtigeAntwort = "Greentea";
                break;
            case 5:
                richtigeAntwort = "Flying Power";
                break;
            case 6:
                richtigeAntwort = "Milch";
                break;
            case 7:
                richtigeAntwort = "Pizzaschifferl";
                break;
            case 8:
                richtigeAntwort = "Speed";
                break;
        }

        // Shuffle the answers to avoid duplicates
        List<string> shuffledAnswers = new List<string>(Antworten);
        shuffledAnswers.Shuffle();

        // Assign shuffled answers to buttons ensuring unique placement for correct answer
        for (int i = 0; i < Buttons.Length; i++)
        {
            if (i < AntwortenText.Length)
            {
                if (i == 0)
                    AntwortenText[i].text = richtigeAntwort; // Place correct answer in first button text
                else
                    AntwortenText[i].text = shuffledAnswers[i - 1]; // Assign shuffled answers to other buttons
            }
        }
    }
    
    // Update is called once per frame
    void Update()
    {

    }
}

// Extension method to shuffle a list
public static class ListExtensions
{
    public static void Shuffle<T>(this IList<T> list)
    {
        int n = list.Count;
        while (n > 1)
        {
            n--;
            int k = Random.Range(0, n + 1);
            T value = list[k];
            list[k] = list[n];
            list[n] = value;
        }
    }
}
