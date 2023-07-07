using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class koffer : MonoBehaviour
{

    
  private Animation animKoffer;
  public float startTime;
  public float stopTime;
    // Start is called before the first frame update
    void Start()
    {
        animKoffer = gameObject.GetComponent<Animation>();
        Invoke("startTurb", startTime);
        Invoke("stopTurb", stopTime);
    }

    // Update is called once per frame
    void startTurb()
    {
       animKoffer.Play("koffer"); 
    }
     void stopTurb()
    {
       animKoffer.Stop("koffer"); 
    }


}
