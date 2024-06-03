using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScaleFromMic : MonoBehaviour
{
    public AudioLoudnessDetection detector;
    public AudioSource source;

    public Vector3 minScale;
    public Vector3 maxScale;

    [SerializeField] Slider volumeSlider;
    [SerializeField] Slider rightArea;
    [SerializeField] float rightAreaFloatStart;
    [SerializeField] float rightAreaFloatEnd;

    [SerializeField] float maxLoudness;
    public float loudnessSensibility = 8f;
    public float threshold = 0.0005f;

    [SerializeField] private List<float> loudnessList;
    [SerializeField] public List<float> lastSecs;

    private IEnumerator coroutine;

    [SerializeField] GameObject bgSlider;

    [SerializeField] Color32 dunkelBlau;
    [SerializeField] Text zuLautText;

    [SerializeField] GameObject sprichImage;

    [SerializeField] Button activationButton;

    static public bool spielGewonnen;
    static public bool spielVerloren;

    private void Start()
    {
        rightAreaFloatStart = Random.Range(0.4f, 0.85f);
        rightArea.value = rightAreaFloatStart;
        rightAreaFloatEnd = rightAreaFloatStart + 0.1f;
        dunkelBlau = new Color32(63, 114, 196, 255);
        
    }
    private void Update()
    {
        float loudness = detector.GetLoudnessFromMicrophone() *10 ;
        if (loudness < threshold)
        {
            loudness = 0;
        }
        volumeSlider.value = loudness;
        loudnessList.Add(loudness);
        if (loudnessList.Count > 130)
        {
            loudnessList.RemoveAt(0);
        }
        if (loudness > rightAreaFloatEnd)
        {
            bgSlider.GetComponent<Image>().color = Color.red;
            zuLautText.gameObject.SetActive(true);
        }
        else
        {
            bgSlider.GetComponent<Image>().color = dunkelBlau;
            zuLautText.gameObject.SetActive(false);
        }

    }

    public void PhraseSaid()
    {
        lastSecs.Clear();
        sprichImage.gameObject.SetActive(true);
        activationButton.GetComponent<Button>().interactable = false;
        coroutine = WaitTalk(2.0f);
        StartCoroutine(coroutine);
        activationButton.GetComponent<Image>().enabled = false;
    }

    IEnumerator WaitTalk(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        foreach (float loudnessItem in loudnessList)
        {
            lastSecs.Add(loudnessItem);
        }
        lastSecs.Sort();
        maxLoudness = lastSecs[129];
        if (rightAreaFloatStart < maxLoudness)
        {
            if (rightAreaFloatEnd > maxLoudness)
            {
                Debug.Log("Gewonnen!");
                StaticVariablen.hatHighscore = false;
                StaticVariablen.gewonnen = "Glückwunsch!!!";
                StaticVariablen.whichScene = "KassaSchrei";
                SceneManager.LoadScene(4);
            }
        }
        if (rightAreaFloatStart > maxLoudness)
        {
            Debug.Log("Verloren");
            StaticVariablen.hatHighscore = false;
            StaticVariablen.gewonnen = "Schade";
            StaticVariablen.whichScene = "KassaSchrei";
            SceneManager.LoadScene(4);
        }
        if (rightAreaFloatEnd < maxLoudness)
        {
            Debug.Log("Verloren");
            StaticVariablen.hatHighscore = false;
            StaticVariablen.gewonnen = "Schade";
            StaticVariablen.whichScene = "KassaSchrei";
            SceneManager.LoadScene(4);
        }
        sprichImage.gameObject.SetActive(false);
        activationButton.GetComponent<Button>().interactable = true;
        activationButton.GetComponent<Image>().enabled = false;
    }
}
