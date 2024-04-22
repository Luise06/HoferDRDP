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
    public string richtigeAntwort;
    public Button Button1;
    public Button Button2;
    public Button Button3;
    public Button Button4;
    // Start is called before the first frame update
    void Start()
    {
        int randomIndex = Random.Range(0, shdwSprites.Length);
        shdwSprites[randomIndex].SetActive(true);
        if (randomIndex == 0)
        {
            richtigeAntwort = "Disco";
        }

        if (randomIndex == 1)
        {
            richtigeAntwort = "Cocos";
        }

        if (randomIndex == 2)
        {
            richtigeAntwort = "Doppelkekse";
        }

        if (randomIndex == 3)
        {
            richtigeAntwort = "Eistee";
        }

        if (randomIndex == 4)
        {
            richtigeAntwort = "Greentea";
        }

        if (randomIndex == 5)
        {
            richtigeAntwort = "Flying Power";
        }

        if (randomIndex == 6)
        {
            richtigeAntwort = "Milch";
        }

        if (randomIndex == 7)
        {
            richtigeAntwort = "Pizzaschiffel";
        }

        if (randomIndex == 8)
        {
            richtigeAntwort = "Speed";
        }

        int randomAntworten = Random.Range(0, Antworten.Length);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
