using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turbulence : MonoBehaviour
{
    
  private Animation animTurb;
  public float startTime;
  public float stopTime;
    // Start is called before the first frame update
    void Start()
    {
        animTurb = gameObject.GetComponent<Animation>();
        Invoke("startTurb", startTime);
        Invoke("stopTurb", stopTime);
    }

    // Update is called once per frame
    void startTurb()
    {
       animTurb.Play("Turbulenz"); 
    }
     void stopTurb()
    {
       animTurb.Stop("Turbulenz"); 
    }
}

