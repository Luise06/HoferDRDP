using UnityEngine.Windows.Speech;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;

public class PhraseRecogniser : MonoBehaviour
{
    private KeywordRecognizer keywordRecognizer;
    private Dictionary<string, Action> actions = new Dictionary<string, Action>();
    public static bool phraseSaid;

    [SerializeField] private ScaleFromMic scaleFromMic;

    private void Start()
    {
        actions.Add("zweite kassa bitte", Kassa);

        keywordRecognizer = new KeywordRecognizer(actions.Keys.ToArray());
        keywordRecognizer.OnPhraseRecognized += RecognizedSpeech;
        keywordRecognizer.Start();
    }
    private void Update()
    {

    }

    private void RecognizedSpeech(PhraseRecognizedEventArgs speech)
    {
        Debug.Log(speech.text);
        actions[speech.text].Invoke();
    }


    private void Kassa()
    {
        scaleFromMic.lastSecs.Clear();
        Debug.Log(" Kassa geht");
        scaleFromMic.PhraseSaid();
    }
}
