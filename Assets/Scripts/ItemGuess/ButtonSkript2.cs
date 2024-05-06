using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ButtonSkript2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void CheckButton()
    {
        string textInButton = transform.GetChild(0).GetComponent<TextMeshProUGUI>().text;

        if (Eventyy.richtigeAntwort == textInButton)
        {
            SceneManager.LoadScene("ItemGuess3");
        }
        else
        {
            Debug.Log("Falschehehheh");
        }
    }
}
