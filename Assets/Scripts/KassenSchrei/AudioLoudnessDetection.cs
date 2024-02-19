using UnityEngine;

public class AudioLoudnessDetection : MonoBehaviour

{
    public int sampleWindow = 128;
    private AudioClip microphoneClip;

    private void Start()
    {
        MicrophoneToAudioClip();
    }
    public void MicrophoneToAudioClip()
    {
        string microphoneName = Microphone.devices[0];
        microphoneClip = Microphone.Start(microphoneName, true, 20, AudioSettings.outputSampleRate);
    }

    public void Stop()
    {
        Microphone.End(Microphone.devices[0]);
    }

    public float GetLoudnessFromMicrophone()
    {
        return GetLoudnessFromAudioClip(Microphone.GetPosition(Microphone.devices[0]), microphoneClip);
    }
    public float GetLoudnessFromAudioClip(int clipPosition, AudioClip clip)

    {

        int startPosition = clipPosition - sampleWindow;

        float[] waveData = new float[sampleWindow];

        clip.GetData(waveData, startPosition);



        float totalLoudness = 0f;

        for (int i = 0; i < sampleWindow; i++)

        {

            totalLoudness += Mathf.Abs(waveData[i]);

        }



        return totalLoudness / sampleWindow;

    }

}

