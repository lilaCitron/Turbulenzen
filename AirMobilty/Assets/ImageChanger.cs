using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ImageChanger : MonoBehaviour
{
    public Image entertainment;
    public Sprite welcome;
    public float changeTime = 2f; // Zeit in Sekunden, nach der das Bild gewechselt wird
    private float timer;
    private bool imageChanged;
    private void Start()
    {
        timer = changeTime;
        imageChanged = false;
    }
    private void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0 && !imageChanged)
        {
            entertainment.sprite = welcome;
            imageChanged = true;
        }
    }
}
