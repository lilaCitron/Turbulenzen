using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript: MonoBehaviour
{
    public float startTime;
    public float stopTime;
    public AudioSource myAudio;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("playAudio", startTime);
        Invoke("stopAudio", stopTime);
    }


    void playAudio()
    {
        myAudio.Play();
    }

    void stopAudio()
    {
        myAudio.Stop();
    }
}
