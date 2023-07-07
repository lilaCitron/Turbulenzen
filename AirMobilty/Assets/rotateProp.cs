using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class rotateProp : MonoBehaviour
{
    public GameObject prop1,prop2, prop3, prop4;
    public Vector3 _rotation;
    
    // Update is called once per frame
    void Update()
    {
        prop1.transform.transform.Rotate(_rotation * Time.deltaTime);
    }
}

