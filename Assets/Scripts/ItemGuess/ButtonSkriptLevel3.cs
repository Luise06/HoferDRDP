using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonSkriptLevel3 : MonoBehaviour
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
            AudioSourceRichtig.PlayOneShot(Richtig);
            Eventyy.Score++;
            transform.GetChild(0).GetComponent<TextMeshProUGUI>().color = Color.green;
            StartCoroutine(ChangeSceneAfterDelay(3f));
            IEnumerator ChangeSceneAfterDelay(float delay)
            {
                yield return new WaitForSeconds(delay);
                SceneManager.LoadScene("GewonnenVerloren");
            }
        }
        else
        {
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
                SceneManager.LoadScene("GewonnenVerloren");
            }
        }
    }
}