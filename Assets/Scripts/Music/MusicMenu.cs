using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicMenu : MonoBehaviour
{
    public Slider sliderMenu;
    private AudioSource audiSource; 
    private AudioSource SFXSource;
    void Start()
    {
        audiSource = GetComponent<AudioSource>();

        if (sliderMenu != null)
        {
            sliderMenu.value = audiSource.volume;
            sliderMenu.onValueChanged.AddListener(ChangeVolumen);
        }
    }

    public void ChangeVolumen(float newVolumen) 
    {
       audiSource.volume = newVolumen;
    }
}
