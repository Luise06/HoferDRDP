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

    [SerializeField] float maxLoudness;
    public float loudnessSensibility = 0.2f;
    public float threshold = 0.1f;

    [SerializeField] private List<float> loudnessList;
    [SerializeField] public List<float> lastSecs;

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
        if (loudnessList.Count > 90)
        {
            loudnessList.RemoveAt(0);
        }
    }

    public void PhraseSaid()
    {
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
