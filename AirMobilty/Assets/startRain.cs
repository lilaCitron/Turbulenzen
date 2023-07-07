using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class startRain : MonoBehaviour
{
    public ParticleSystem myRain;
    public float startTime;
    public float stopTime;
    // Start is called before the first frame update
    void Start()
    {
        myRain.Stop();
        Invoke("makeRain", startTime);
        Invoke("stopRain", stopTime);
    }

    // starts Particle System
    void makeRain()
    {
        myRain.Play();
    }

    void stopRain()
    {
        myRain.Stop();
    }
}
