using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonSkriptLevel2 : MonoBehaviour
{
    public GameObject Falsch;
    public Button Button1;
    public Button Button2;
    public Button Button3;
    public Button Button4;
    public AudioClip Richtig;
    public AudioClip Falschee;
    public AudioSource AudioSourceRichtig;
    public AudioSource AudioSourceFalsch;
    public GameObject Disco;
    public GameObject Doppelkekse;
    public GameObject Eistee;
    public GameObject FlyingPower;
    public GameObject Milch;
    public GameObject Pizzaschifferl;
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
            if (Eventyy.richtigeAntwort == "Disco")
            {
                Disco.SetActive(true);
            }

            if (Eventyy.richtigeAntwort == "Doppelkekse")
            {
                Doppelkekse.SetActive(true);
            }

            if (Eventyy.richtigeAntwort == "Eistee")
            {
                Eistee.SetActive(true);
            }

            if (Eventyy.richtigeAntwort == "Flying Power")
            {
                FlyingPower.SetActive(true);
            }

            if (Eventyy.richtigeAntwort == "Milch")
            {
                Milch.SetActive(true);
            }

            if (Eventyy.richtigeAntwort == "Pizzaschifferl")
            {
                Pizzaschifferl.SetActive(true);
            }
            AudioSourceRichtig.PlayOneShot(Richtig);
            Eventyy.Score++;
            transform.GetChild(0).GetComponent<TextMeshProUGUI>().color = Color.green;
            StartCoroutine(ChangeSceneAfterDelay(3f));
            IEnumerator ChangeSceneAfterDelay(float delay)
            {
                yield return new WaitForSeconds(delay);
                SceneManager.LoadScene("ItemGuess3");
            }
        }
        else
        {
            AudioSourceFalsch.PlayOneShot(Falschee);
            Debug.Log("Falschehehheh");
            Falsch.SetActive(true);
            Button1.enabled = false;
            Button2.enabled = false;
            Button3.enabled = false;
            Button4.enabled = false;
            transform.GetChild(0).GetComponent<TextMeshProUGUI>().color = Color.red;
            StartCoroutine(ChangeSceneAfterDelay(3f));
            IEnumerator ChangeSceneAfterDelay(float delay)
            {
                yield return new WaitForSeconds(delay);
                SceneManager.LoadScene("ItemGuess3");
            }
        }
    }
}
