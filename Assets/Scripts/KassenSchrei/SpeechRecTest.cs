using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KKSpeech;
using UnityEngine.UI;

public class SpeechRecTest : MonoBehaviour
{
    public Button recStart;
    public Text resultText;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartRec()
    {
        SpeechRecognizer.StartRecording(true);
        recStart.GetComponentInChildren<Text>().text = "Stop Recording";
        resultText.text = "Say something :-)";
    }
   
}
