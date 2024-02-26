using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScaleFromMic : MonoBehaviour
{
    public AudioLoudnessDetection detector;
    public AudioSource source;

    public Vector3 minScale;
    public Vector3 maxScale;

    [SerializeField] Slider volumeSlider;
    [SerializeField] Slider rightArea;
    float rightAreaFloatStart;
    float rightAreaFloatEnd;
    [SerializeField] Text loudnessText;
    [SerializeField] Text maxLoudnessText;

    [SerializeField] float maxLoudness;
    public float loudnessSensibility = 2f;
    public float threshold = 0.1f;

    [SerializeField] private List<float> loudnessList;
    [SerializeField] public List<float> lastSecs;

    private IEnumerator coroutine;

    private void Start()
    {
        rightAreaFloatStart = Random.Range(0.4f, 0.85f);
        rightArea.value = rightAreaFloatStart;
        rightAreaFloatEnd = rightAreaFloatStart + 0.1f;
    }
    private void FixedUpdate()
    {
        float loudness = detector.GetLoudnessFromMicrophone() *2 ;
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
        loudnessText.text = loudness.ToString();
        maxLoudnessText.text = maxLoudness.ToString();
    }

    public void PhraseSaid()
    {
        coroutine = WaitTalk(3.0f);
        StartCoroutine(coroutine);
    }

    IEnumerator WaitTalk(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        lastSecs.Clear();
        foreach (float loudnessItem in loudnessList)
        {
            lastSecs.Add(loudnessItem);
        }
        lastSecs.Sort();
        maxLoudness = lastSecs[89];
        if (rightAreaFloatStart < maxLoudness)
        {
            if (rightAreaFloatEnd > maxLoudness)
            {
                Debug.Log("Gewonnen!");
            }
        }
        if (rightAreaFloatStart > maxLoudness)
        {
            Debug.Log("Verloren");
        }
        if (rightAreaFloatEnd < maxLoudness)
        {
            Debug.Log("Verloren");
        }
    }
}
